using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        public List<CommisionInfo> listCommision = new List<CommisionInfo>();


        public void OnGet()
        {
            try
            {

                string conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    string Insert = "SELECT [NR_ZLECENIA], [NR_TRAWERSY], [DATA_DOSTAWY], [DATA_REALIZACJI],[NAZWA_WYROBU]," +
                        " [UWAGI] ,[ILO��_SZTUK] ,[ILO��_M2] ,[PODK�AD], [�RUT],[STATUS],[KLIENT],[DOSTAWCA_FARBY],[KOLOR_FARBY],[TYP_FARBY],[POWIERZCHNIA]," +
                        "[PO�YSK],[ID_ZLECENIA] FROM[BAZA_MALARNIA].[dbo].[Zecenie]";
                    SqlCommand sqlInsert = new SqlCommand(Insert, connection);
                    using (SqlDataReader reader = sqlInsert.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CommisionInfo commisionInfo = new CommisionInfo();
                            commisionInfo.NR_ZLECENIA = reader.GetString(0);
                            commisionInfo.NR_TRAWERSY = reader.GetDecimal(1).ToString();
                            commisionInfo.DATA_DOSTAWY = reader.GetDateTime(2).ToShortDateString();
                            commisionInfo.DATA_REALIZACJI = reader.GetDateTime(3).ToShortDateString();
                            commisionInfo.NAZWA_WYROBU = reader.GetString(4);
                            commisionInfo.UWAGI = reader.GetString(5);
                            commisionInfo.ILO��_SZTUK = reader.GetDecimal(6).ToString();
                            commisionInfo.ILO��_M2 = reader.GetDecimal(7).ToString();
                            commisionInfo.PODK�AD = reader.GetBoolean(8).ToString();
                            commisionInfo.�RUT = reader.GetBoolean(9).ToString();
                            commisionInfo.STATUS = reader.GetString(10);
                            commisionInfo.KLIENT = reader.GetString(11);
                            commisionInfo.DOSTAWCA_FARBY = reader.GetString(12);
                            commisionInfo.KOLOR_FARBY = reader.GetString(13);
                            commisionInfo.TYP_FARBY = reader.GetString(14);
                            commisionInfo.POWIERZCHNIA = reader.GetString(15);
                            commisionInfo.PO�YSK = reader.GetString(16);
                            commisionInfo.id = reader.GetDecimal(17).ToString();
                            listCommision.Add(commisionInfo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }

    public class CommisionInfo
    {
        public string? NR_ZLECENIA;
        public string? NR_TRAWERSY;
        public string? DATA_DOSTAWY;
        public string? DATA_REALIZACJI;
        public string? NAZWA_WYROBU;
        public string? UWAGI;
        public string? ILO��_SZTUK;
        public string? ILO��_M2;
        public string? PODK�AD;
        public string? �RUT;
        public string? STATUS;
        public string? KLIENT;
        public string? DOSTAWCA_FARBY;
        public string? KOLOR_FARBY;
        public string? TYP_FARBY;
        public string? POWIERZCHNIA;
        public string? PO�YSK;
        public string? id;
    }
}
