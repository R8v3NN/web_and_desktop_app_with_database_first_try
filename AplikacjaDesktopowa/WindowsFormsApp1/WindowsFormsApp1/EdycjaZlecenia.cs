using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EdycjaZlecenia : Form
    {
        public EdycjaZlecenia()
        {
            InitializeComponent();
        }

        private void EdycjaZlecenia_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet19.KLIENT' . Możesz go przenieść lub usunąć.
            this.kLIENTTableAdapter.Fill(this.bAZA_MALARNIADataSet19.KLIENT);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet18.PLAN_ZLECEN' . Możesz go przenieść lub usunąć.
            this.pLAN_ZLECENTableAdapter.Fill(this.bAZA_MALARNIADataSet18.PLAN_ZLECEN);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet17.STATUS_ZLECENIA' . Możesz go przenieść lub usunąć.
            this.sTATUS_ZLECENIATableAdapter.Fill(this.bAZA_MALARNIADataSet17.STATUS_ZLECENIA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet16.POŁYSK' . Możesz go przenieść lub usunąć.
            this.pOŁYSKTableAdapter.Fill(this.bAZA_MALARNIADataSet16.POŁYSK);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet15.POWIERZCHNIA' . Możesz go przenieść lub usunąć.
            this.pOWIERZCHNIATableAdapter.Fill(this.bAZA_MALARNIADataSet15.POWIERZCHNIA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet14.TYP_FARBY' . Możesz go przenieść lub usunąć.
            this.tYP_FARBYTableAdapter.Fill(this.bAZA_MALARNIADataSet14.TYP_FARBY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet13.KOLOR_FARBY' . Możesz go przenieść lub usunąć.
            this.kOLOR_FARBYTableAdapter.Fill(this.bAZA_MALARNIADataSet13.KOLOR_FARBY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet11.DOSTAWCA_FARBY' . Możesz go przenieść lub usunąć.
            this.dOSTAWCA_FARBYTableAdapter.Fill(this.bAZA_MALARNIADataSet11.DOSTAWCA_FARBY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_ID_ZLECENIA_SELECT.ZLECENIA' . Możesz go przenieść lub usunąć.
            this.zLECENIATableAdapter.Fill(this.bAZA_ID_ZLECENIA_SELECT.ZLECENIA);

        }

        private void cbEIDZLECENIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEIDZLECENIA.BeginUpdate();
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            SqlCommand selectTabelZlecenie = new SqlCommand("SELECT [NR_ZLECENIA], [NR_TRAWERSY] ,[DATA_DOSTAWY] ,[DATA_REALIZACJI] ,[NAZWA_WYROBU] ,[UWAGI] ,[ILOŚĆ_SZTUK] , " +
                "[ILOŚĆ_M2] ,[PODKŁAD] ,[ŚRUT] ,[STATUS] ,[KLIENT] ,[DOSTAWCA_FARBY] ,[KOLOR_FARBY] ,[TYP_FARBY] ,[POWIERZCHNIA] ,[POŁYSK] FROM [BAZA_MALARNIA].[dbo].[View_Zlecenie] Where [NR_ZLECENIA] = '" + cbEIDZLECENIA.Text+ "'", con);
            SqlDataReader reader = selectTabelZlecenie.ExecuteReader();
            
            if (reader.Read())
            {
                if (DateTime.TryParse(reader["DATA_DOSTAWY"].ToString(), out DateTime dataDostawyValue))
                {
                    dtEDATADOSTAWY.Value = dataDostawyValue;
                }
                if (DateTime.TryParse(reader["DATA_REALIZACJI"].ToString(), out DateTime dataRealizacjiValue))
                {
                    dtEDATAREALIZACJI.Value = dataRealizacjiValue;
                }
                tbENAZWAWYROB.Text = reader["NAZWA_WYROBU"].ToString();
                numENRTRAWERSY.Value = Convert.ToDecimal(reader["NR_TRAWERSY"]);
                numEILOSCS.Value = Convert.ToDecimal(reader["ILOŚĆ_SZTUK"]);
                numEILOSCM.Value = Convert.ToDecimal(reader["ILOŚĆ_M2"]);
                tbEUWAGI.Text = reader["NAZWA_WYROBU"].ToString();
                cbEKLIENT.Text = reader["KLIENT"].ToString();
                cbEDOSTAWCA.Text = reader["DOSTAWCA_FARBY"].ToString();
                cbEKOLOR.Text = reader["KOLOR_FARBY"].ToString();
                cbETYPFARBY.Text = reader["TYP_FARBY"].ToString();
                cbEPOWIERZCHNIA.Text = reader["POWIERZCHNIA"].ToString();
                cbEPOLYSK.Text = reader["POŁYSK"].ToString();
                cbESRUT.Checked = Convert.ToBoolean(reader["ŚRUT"]);
                cbEPODKLAD.Checked = Convert.ToBoolean(reader["PODKŁAD"]);
                cbESTATUS.Text = reader["STATUS"].ToString();
            }
            reader.Close();
            con.Close();
            cbEIDZLECENIA.EndUpdate();
        }

        private void btnDODAJ_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            SqlCommand updateZlecenie = new SqlCommand("UPDATE [dbo].[ZLECENIA] SET " +
                "[ID_STATUS] = @ID_STATUS, " +
                "[ID_POWIERZCHNIA] = @ID_POWIERZCHNIA, " +
                "[ID_POŁYSK] = @ID_POŁYSK, " +
                "[ID_KOLOR] = @ID_KOLOR, " +
                "[ID_DOSTAWCA_FARBY] = @ID_DOSTAWCA_FARBY, " +
                "[ID_KLIENT] = @ID_KLIENT, " +
                "[ID_TYP_FARBY] = @ID_TYP_FARBY, " +
                "[DATA_DOSTAWY] = @DATA_DOSTAWY, " +
                "[DATA_REALIZACJI] = @DATA_REALIZACJI, " +
                "[NAZWA_WYROBU] = @NAZWA_WYROBU, " +
                "[UWAGI] = @UWAGI, " +
                "[ILOŚĆ_SZTUK] = @ILOŚĆ_SZTUK, " +
                "[ILOŚĆ_M2] = @ILOŚĆ_M2, " +
                "[PODKŁAD] = @PODKŁAD, " +
                "[ŚRUT] = @ŚRUT, " +
                "[NR_TRAWERSY] = @NR_TRAWERSY " +
                "WHERE [NR_ZLECENIA] = @NR_ZLECENIA", con);
            int podklad = 0;
            int srut = 0;
            if (cbEPODKLAD.Checked == true)
                podklad = 1;
            else podklad = 0;
            if (cbESRUT.Checked == true)
                srut = 1;
            else srut = 0;

            updateZlecenie.Parameters.AddWithValue("@NR_ZLECENIA", cbEIDZLECENIA.Text);
            updateZlecenie.Parameters.AddWithValue("@NR_TRAWERSY", Convert.ToDecimal(numENRTRAWERSY.Value));
            updateZlecenie.Parameters.AddWithValue("@DATA_DOSTAWY", dtEDATADOSTAWY.Value);
            updateZlecenie.Parameters.AddWithValue("@DATA_REALIZACJI", dtEDATAREALIZACJI.Value);
            updateZlecenie.Parameters.AddWithValue("@NAZWA_WYROBU", tbENAZWAWYROB.Text);
            updateZlecenie.Parameters.AddWithValue("@UWAGI", tbEUWAGI.Text);
            updateZlecenie.Parameters.AddWithValue("@ILOŚĆ_SZTUK", Convert.ToDecimal(numEILOSCS.Value));
            updateZlecenie.Parameters.AddWithValue("@ILOŚĆ_M2", Convert.ToDecimal(numEILOSCM.Value));
            updateZlecenie.Parameters.AddWithValue("@PODKŁAD", podklad);
            updateZlecenie.Parameters.AddWithValue("@ŚRUT", srut);
            updateZlecenie.Parameters.AddWithValue("@ID_STATUS", cbESTATUS.SelectedValue);
            updateZlecenie.Parameters.AddWithValue("@ID_KLIENT", cbEKLIENT.SelectedValue);
            updateZlecenie.Parameters.AddWithValue("@ID_DOSTAWCA_FARBY", cbEDOSTAWCA.SelectedValue);
            updateZlecenie.Parameters.AddWithValue("@ID_KOLOR", cbEKOLOR.SelectedValue);
            updateZlecenie.Parameters.AddWithValue("@ID_TYP_FARBY", cbETYPFARBY.SelectedValue);
            updateZlecenie.Parameters.AddWithValue("@ID_POWIERZCHNIA", cbEPOWIERZCHNIA.SelectedValue);
            updateZlecenie.Parameters.AddWithValue("@ID_POŁYSK", cbEPOLYSK.SelectedValue);

            int rowsAffected = updateZlecenie.ExecuteNonQuery();
            if (rowsAffected != 0)
            {
                MessageBox.Show("Zlecenie zostało zaktualizowane!");
            }
            else
            {
                MessageBox.Show("error");
            }
            con.Close();
        }
    }
}
