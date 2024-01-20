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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class DodawanieZlecenia : Form
    {
        public DodawanieZlecenia()
        {
            InitializeComponent();
        }

        private void DodawanieZlecenia_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet10.STATUS_ZLECENIA' . Możesz go przenieść lub usunąć.
            this.sTATUS_ZLECENIATableAdapter.Fill(this.bAZA_MALARNIADataSet10.STATUS_ZLECENIA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet7.ZLECENIA' . Możesz go przenieść lub usunąć.
            this.zLECENIATableAdapter.Fill(this.bAZA_MALARNIADataSet7.ZLECENIA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet6.POŁYSK' . Możesz go przenieść lub usunąć.
            this.pOŁYSKTableAdapter.Fill(this.bAZA_MALARNIADataSet6.POŁYSK);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet5.POWIERZCHNIA' . Możesz go przenieść lub usunąć.
            this.pOWIERZCHNIATableAdapter.Fill(this.bAZA_MALARNIADataSet5.POWIERZCHNIA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet4.TYP_FARBY' . Możesz go przenieść lub usunąć.
            this.tYP_FARBYTableAdapter.Fill(this.bAZA_MALARNIADataSet4.TYP_FARBY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet3.KOLOR_FARBY' . Możesz go przenieść lub usunąć.
            this.kOLOR_FARBYTableAdapter.Fill(this.bAZA_MALARNIADataSet3.KOLOR_FARBY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet1.DOSTAWCA_FARBY' . Możesz go przenieść lub usunąć.
            this.dOSTAWCA_FARBYTableAdapter.Fill(this.bAZA_MALARNIADataSet1.DOSTAWCA_FARBY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bAZA_MALARNIADataSet.KLIENT' . Możesz go przenieść lub usunąć.
            this.kLIENTTableAdapter.Fill(this.bAZA_MALARNIADataSet.KLIENT);

        }

        private void bAZAMALARNIADataSet2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnDODAJ_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True");
            con.Open();
            int oczekiwanie = 1;
            int podklad = 0;
            int srut = 0;
            if (cbPODKLAD.Checked == true)
                podklad = 1;
            else podklad = 0;
            if (cbSRUT.Checked == true)
                srut = 1;
            else srut = 0;
           
            using (SqlCommand sqlCommandInsert = new SqlCommand("INSERT INTO ZLECENIA ([ID_STATUS],[ID_POWIERZCHNIA], [ID_POŁYSK], [ID_KOLOR], [ID_DOSTAWCA_FARBY], [ID_KLIENT], [ID_TYP_FARBY]," +
                    " [NR_ZLECENIA], [DATA_DOSTAWY], [DATA_REALIZACJI], [NAZWA_WYROBU], [UWAGI], [ILOŚĆ_SZTUK], [ILOŚĆ_M2], [PODKŁAD], [ŚRUT], [NR_TRAWERSY]) " +
                    "VALUES (@ID_STATUS, @ID_POWIERZCHNIA, @ID_POŁYSK, @ID_KOLOR, @ID_DOSTAWCA_FARBY, @ID_KLIENT, @ID_TYP_FARBY, @NR_ZLECENIA, @DATA_DOSTAWY, @DATA_REALIZACJI, " +
                    "@NAZWA_WYROBU, @UWAGI, @ILOŚĆ_SZTUK, @ILOŚĆ_M2, @PODKŁAD, @ŚRUT, @NR_TRAWERSY)", con))
            {
                sqlCommandInsert.Parameters.AddWithValue("@ID_STATUS", oczekiwanie);
                sqlCommandInsert.Parameters.AddWithValue("@ID_POWIERZCHNIA", cbPOWIERZCHNIA.SelectedValue);
                sqlCommandInsert.Parameters.AddWithValue("@ID_POŁYSK", cbPOLYSK.SelectedValue);
                sqlCommandInsert.Parameters.AddWithValue("@ID_KOLOR", cbKOLOR.SelectedValue);
                sqlCommandInsert.Parameters.AddWithValue("@ID_DOSTAWCA_FARBY", cbDOSTAWCA.SelectedValue);
                sqlCommandInsert.Parameters.AddWithValue("@ID_KLIENT", cbKLIENT.SelectedValue);
                sqlCommandInsert.Parameters.AddWithValue("@ID_TYP_FARBY", cbTYPFARBY.SelectedValue);
                sqlCommandInsert.Parameters.AddWithValue("@NR_ZLECENIA", tbIDZLECENIA.Text);
                sqlCommandInsert.Parameters.AddWithValue("@DATA_DOSTAWY", dtDATADOSTAWY.Value);
                sqlCommandInsert.Parameters.AddWithValue("@DATA_REALIZACJI", dtDATAREALIZACJI.Value);
                sqlCommandInsert.Parameters.AddWithValue("@NAZWA_WYROBU", tbNAZWAWYROB.Text);
                sqlCommandInsert.Parameters.AddWithValue("@UWAGI", tbUWAGI.Text);
                sqlCommandInsert.Parameters.AddWithValue("@ILOŚĆ_SZTUK", numILOSCS.Value);
                sqlCommandInsert.Parameters.AddWithValue("@ILOŚĆ_M2", numILOSCM.Value);
                sqlCommandInsert.Parameters.AddWithValue("@PODKŁAD", podklad);
                sqlCommandInsert.Parameters.AddWithValue("@ŚRUT", srut);
                sqlCommandInsert.Parameters.AddWithValue("@NR_TRAWERSY", numNRTRAWERSY.Value);

                // Execute the query
                int i = sqlCommandInsert.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Dodano zlecenie do bazy!");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            con.Close();
        }
    }
}
