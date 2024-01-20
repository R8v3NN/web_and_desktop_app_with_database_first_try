using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Data.SqlTypes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet26.PLAN_ZLECEN' . Możesz go przenieść lub usunąć.
            this.pLAN_ZLECENTableAdapter.Fill(this.bAZA_MALARNIADataSet26.PLAN_ZLECEN);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet22.DANE_OPERACJI' . Możesz go przenieść lub usunąć.
            this.dANE_OPERACJITableAdapter.Fill(this.bAZA_MALARNIADataSet22.DANE_OPERACJI);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet20.OPERACJE' . Możesz go przenieść lub usunąć.
            this.oPERACJETableAdapter1.Fill(this.bAZA_MALARNIADataSet20.OPERACJE);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet9.OPERACJE' . Możesz go przenieść lub usunąć.
            this.oPERACJETableAdapter.Fill(this.bAZA_MALARNIADataSet9.OPERACJE);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'wYSZUKANIE_OPERACJI_ZLECENIA.ZLECENIA' . Możesz go przenieść lub usunąć.
            this.zLECENIATableAdapter1.Fill(this.wYSZUKANIE_OPERACJI_ZLECENIA.ZLECENIA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet8.ZLECENIA' . Możesz go przenieść lub usunąć.
            this.zLECENIATableAdapter.Fill(this.bAZA_MALARNIADataSet8.ZLECENIA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet2.View_Zlecenie' . Możesz go przenieść lub usunąć.
            this.view_ZlecenieTableAdapter1.Fill(this.bAZA_MALARNIADataSet2.View_Zlecenie);

        }

        private void DODAJZLECENIE_Click(object sender, EventArgs e)
        {
            var myForm = new DodawanieZlecenia();
            myForm.Show();
        }
        private void showDataBaseZlec()
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            SqlDataAdapter showTabelZlecenie = new SqlDataAdapter("SELECT [NR_ZLECENIA], [NR_TRAWERSY] ,[DATA_DOSTAWY] ,[DATA_REALIZACJI] ,[NAZWA_WYROBU] ,[UWAGI] ,[ILOŚĆ_SZTUK] , " +
                "[ILOŚĆ_M2] ,[PODKŁAD] ,[ŚRUT] ,[STATUS] ,[KLIENT] ,[DOSTAWCA_FARBY] ,[KOLOR_FARBY] ,[TYP_FARBY] ,[POWIERZCHNIA] ,[POŁYSK] FROM [BAZA_MALARNIA].[dbo].[View_Zlecenie]", con);
            DataTable dtZLECENIE = new DataTable();
            showTabelZlecenie.Fill(dtZLECENIE);
            dgvZLECENIE.DataSource = dtZLECENIE;
            con.Close();
        }
        private void addToDataBase(string nazwatabeli, string nazwakolumny, string wartosc_pola, string powIstniejace, string powDodania)
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            SqlCommand check_If_Exist = new SqlCommand("SELECT COUNT(*) FROM [" + nazwatabeli + "] WHERE [" + nazwakolumny + "] = @wartosc_pola", con);
            check_If_Exist.Parameters.AddWithValue("@wartosc_pola", wartosc_pola);
            int i = (int)check_If_Exist.ExecuteScalar();
            if (i > 0)
            {
                MessageBox.Show("" + powIstniejace + "");
            }
            else if (wartosc_pola == "")
            {
                MessageBox.Show("Brak wartości w polu!");
            }
            else
            {
                using (SqlCommand sqlCommandInsert = new SqlCommand("INSERT INTO " + nazwatabeli + " ([" + nazwakolumny + "])" +
                   "VALUES (@wartosc_pola)", con))
                {
                    sqlCommandInsert.Parameters.AddWithValue("@wartosc_pola", wartosc_pola);
                    int j = sqlCommandInsert.ExecuteNonQuery();

                    if (j != 0)
                    {
                        MessageBox.Show("" + powDodania + "");
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
            }
            con.Close();

        }
        private void btnDODAJDOSTAWCA_Click(object sender, EventArgs e)
        {
            addToDataBase("DOSTAWCA_FARBY", "DOSTAWCA_FARBY", tbDDOSTAWCE.Text, "TDostawca już istnieje w bazie!", "Nowy dostawca farby został dodany do bazy!");
        }

        private void btnDODAJRAL_Click(object sender, EventArgs e)
        {
            addToDataBase("KOLOR_FARBY", "KOLOR_FARBY", tbDRAL.Text, "Ten kolor znajduje się już w bazie!", "Nowy kolor został dodany do bazy!");
        }

        private void btnDODAJKLIENT_Click(object sender, EventArgs e)
        {
            addToDataBase("KLIENT", "KLIENT", tbDKLIENT.Text, "Ten klient już istnieje w bazie!", "Nowy Klient został dodany do bazy!");
        }

        private void btnDODAJPOWIERZCHNIE_Click(object sender, EventArgs e)
        {
            addToDataBase("POWIERZCHNIA", "POWIERZCHNIA", tbDPOWIERZCHNIA.Text, "Ten rodzaj powierzchni już istnieje w bazie!", "Nowa powierzchnia została dodana do bazy!");
        }

        private void btnDODAJPOLYSK_Click(object sender, EventArgs e)
        {
            addToDataBase("POŁYSK", "POŁYSK", tbDPOLYSK.Text, "Ten rodzaj połysku już istnieje w bazie!", "Nowy połysk został dodany do bazy!");
        }

        private void btnDODAJTYP_Click(object sender, EventArgs e)
        {
            addToDataBase("TYP_FARBY", "TYP_FARBY", tbDTYPRAL.Text, "Ten rodzaj farby już istnieje w bazie!", "Nowy rodzaj farby został dodany do bazy!");
        }

        private void btnDODAJSTATUS_Click(object sender, EventArgs e)
        {
            addToDataBase("STATUS_ZLECENIA", "STATUS", tbDSTATUS.Text, "Ten rodzaj statusu już istnieje w bazie!", "Nowy staus został dodany do bazy!");
        }

        private void btnDODAJOPERACJE_Click(object sender, EventArgs e)
        {
            addToDataBase("OPERACJE", "NAZWA_OPERACJI", tbDOPERACJE.Text, "Ten rodzaj operacji już istnieje w bazie!", "Nowa operacja została dodana do bazy!");
        }

        private void btnWYSZUKAJ_Click(object sender, EventArgs e)
        {

        }

        private void btnDODAJOPER_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            using (SqlCommand sqlCommandInsert = new SqlCommand("INSERT INTO DANE_OPERACJI ([ID_ZLECENIA], [ID_OPERACJI], [DATA_OPERACJI], [CZAS_OPERACJI]," +
                " [ZUZYCIE_MATERIALOW]) VALUES (@NRZLECENIA, @IDOPERACJI, @DATAOPERACJI,  @CZASOPERACJI, @ZUZYCIEMAT)", con))
            {
                sqlCommandInsert.Parameters.AddWithValue("@NRZLECENIA", cbNRZLECENIA.SelectedValue);
                sqlCommandInsert.Parameters.AddWithValue("@IDOPERACJI", cbWOPERACJI.SelectedValue);
                sqlCommandInsert.Parameters.AddWithValue("@DATAOPERACJI", dtDATAOPERACJI.Value);
                sqlCommandInsert.Parameters.AddWithValue("@CZASOPERACJI", numCZASOP.Value);
                sqlCommandInsert.Parameters.AddWithValue("@ZUZYCIEMAT", numZUZMAT.Value);
                int i = sqlCommandInsert.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Dodano Operacje " + cbWOPERACJI.Text + " do Zlecenia");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }

            con.Close();
        }

        private void btnPOKAZZLEC_Click(object sender, EventArgs e)
        {
            showDataBaseZlec();
        }

        private void btnEDYTZLEC_Click(object sender, EventArgs e)
        {
            var myForm = new EdycjaZlecenia();
            myForm.Show();
        }

        private void cbNRZLECENIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNRZLECENIA.BeginUpdate();
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            SqlDataAdapter sqDataSelect = new SqlDataAdapter("SELECT OPERACJE.NAZWA_OPERACJI, DANE_OPERACJI.DATA_OPERACJI, " +
                "DANE_OPERACJI.CZAS_OPERACJI, DANE_OPERACJI.ZUZYCIE_MATERIALOW " +
                "FROM [BAZA_MALARNIA].[dbo].[DANE_OPERACJI] AS DANE_OPERACJI " +
                "JOIN [BAZA_MALARNIA].[dbo].[ZLECENIA] AS ZLECENIA ON DANE_OPERACJI.ID_ZLECENIA = ZLECENIA.ID_ZLECENIA " +
                "JOIN [BAZA_MALARNIA].[dbo].[OPERACJE] AS OPERACJE ON DANE_OPERACJI.ID_OPERACJI = OPERACJE.ID_OPERACJI " +
                "WHERE ZLECENIA.NR_ZLECENIA = '" + cbNRZLECENIA.Text + "'", con);
            DataTable dtbOPERACJE = new DataTable();
            sqDataSelect.Fill(dtbOPERACJE);
            dgvOPERACJE.DataSource = dtbOPERACJE;

            con.Close();
            cbNRZLECENIA.EndUpdate();
        }

        private void btnDODAJPLAN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            SqlCommand sqlCommandInsert = new SqlCommand("INSERT INTO PLAN_ZLECEN (DATA_PLANU) VALUES (@DATAPLANU)", con);
            sqlCommandInsert.Parameters.AddWithValue("@DATAPLANU", dtpPLAN.Value);
            int i = sqlCommandInsert.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Dodano nowy plan do Zlecenia");
            }
            else
            {
                MessageBox.Show("error");
            }
            con.Close();
        }

        private void cbPLAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPLAN.BeginUpdate();
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            string query =
                "SELECT " +
                "    ZLECENIA.NR_ZLECENIA, " +
                "    ZLECENIA.DATA_DOSTAWY, " +
                "    ZLECENIA.DATA_REALIZACJI, " +
                "    ZLECENIA.NAZWA_WYROBU, " +
                "    ZLECENIA.UWAGI, " +
                "    ZLECENIA.ILOŚĆ_SZTUK, " +
                "    ZLECENIA.ILOŚĆ_M2, " +
                "    ZLECENIA.PODKŁAD, " +
                "    ZLECENIA.ŚRUT, " +
                "    ZLECENIA.NR_TRAWERSY, " +
                "    KLIENT.KLIENT, " +
                "    DOSTAWCA_FARBY.DOSTAWCA_FARBY, " +
                "    KOLOR_FARBY.KOLOR_FARBY, " +
                "    TYP_FARBY.TYP_FARBY, " +
                "    POWIERZCHNIA.POWIERZCHNIA, " +
                "    POŁYSK.POŁYSK, " +
                "    STATUS_ZLECENIA.STATUS " +
                "FROM " +
                "    dbo.DOSTAWCA_FARBY AS DOSTAWCA_FARBY " +
                "INNER JOIN " +
                "    dbo.ZLECENIA AS ZLECENIA ON DOSTAWCA_FARBY.ID_DOSTAWCA_FARBY = ZLECENIA.ID_DOSTAWCA_FARBY " +
                "INNER JOIN " +
                "    dbo.KLIENT AS KLIENT ON ZLECENIA.ID_KLIENT = KLIENT.ID_KLIENT " +
                "INNER JOIN " +
                "    dbo.KOLOR_FARBY AS KOLOR_FARBY ON ZLECENIA.ID_KOLOR = KOLOR_FARBY.ID_KOLOR " +
                "INNER JOIN " +
                "    dbo.POWIERZCHNIA AS POWIERZCHNIA ON ZLECENIA.ID_POWIERZCHNIA = POWIERZCHNIA.ID_POWIERZCHNIA " +
                "INNER JOIN " +
                "    dbo.TYP_FARBY AS TYP_FARBY ON ZLECENIA.ID_TYP_FARBY = TYP_FARBY.ID_TYP_FARBY " +
                "INNER JOIN " +
                "    dbo.POŁYSK AS POŁYSK ON ZLECENIA.ID_POŁYSK = POŁYSK.ID_POŁYSK " +
                "INNER JOIN " +
                "    dbo.STATUS_ZLECENIA AS STATUS_ZLECENIA ON ZLECENIA.ID_STATUS = STATUS_ZLECENIA.ID_STATUS " +
                "WHERE " +
                "    ZLECENIA.ID_PLANU = @PlanId";

            using (SqlDataAdapter sqDataSelect = new SqlDataAdapter(query, con))
            {
                sqDataSelect.SelectCommand.Parameters.AddWithValue("@PlanId", cbPLAN.SelectedValue);

                DataTable dtbOPERACJE = new DataTable();
                sqDataSelect.Fill(dtbOPERACJE);
                dtgPLAN.DataSource = dtbOPERACJE;
            }
            
            con.Close();
            cbPLAN.EndUpdate();
        }

        private void btnDODAJDOPLANU_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            SqlCommand updateZlecenie = new SqlCommand("UPDATE [dbo].[ZLECENIA] SET " +
               "[ID_PLANU] = @ID_PLANU " +
               "WHERE [NR_ZLECENIA] = @NR_ZLECENIA", con);
            updateZlecenie.Parameters.AddWithValue("@ID_PLANU", cbPLAN.SelectedValue);
            updateZlecenie.Parameters.AddWithValue("@NR_ZLECENIA", cbIDDOPLANU.Text);

            int rowsAffected = updateZlecenie.ExecuteNonQuery();
            if (rowsAffected != 0)
            {
                MessageBox.Show("Zlecenie zostało dodane do planu!");
            }
            else
            {
                MessageBox.Show("error");
            }

            con.Close();
        }

        private void btnWYDZLECEN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            SqlDataAdapter showTabelZlecenie = new SqlDataAdapter("SELECT TOP (1000) [NR_ZLECENIA] , [Wydajnosc_Malowania]  , [Wydajnosc_Podkladu] , [Wydajnosc_Srutowania] , [Wydajnosc_Przygotowania]" +
                "  , [Wydajnosc_Pakowania]  , [Wydajność_Zużycia_Materiałów_Malowania] , [Wydajność_Zużycia_Materiałów_Podkład]FROM[BAZA_MALARNIA].[dbo].[View_1]", con);
            DataTable dtZLECENIE = new DataTable();
            showTabelZlecenie.Fill(dtZLECENIE);
            dgvZLECENIE.DataSource = dtZLECENIE;
            con.Close();
        }
    }
}
       