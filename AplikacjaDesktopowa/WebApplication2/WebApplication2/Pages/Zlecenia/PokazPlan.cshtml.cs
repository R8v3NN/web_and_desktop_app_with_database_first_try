using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication2.Pages.Zlecenia
{
    public class PokazPlanModel : PageModel
    {
		public List<InfoZlecenPlan> listInfoZlecenPlan = new List<InfoZlecenPlan>();
		public void OnGet()
        {
			String id = Request.Query["id"].ToString();
			try
			{
				String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					String Select =
			   "SELECT " +
			   "    ZLECENIA.NR_ZLECENIA, " +
			   "    ZLECENIA.DATA_DOSTAWY, " +
			   "    ZLECENIA.DATA_REALIZACJI, " +
			   "    ZLECENIA.NAZWA_WYROBU, " +
			   "    ZLECENIA.UWAGI, " +
			   "    ZLECENIA.ILOŒÆ_SZTUK, " +
			   "    ZLECENIA.ILOŒÆ_M2, " +
			   "    ZLECENIA.PODK£AD, " +
			   "    ZLECENIA.ŒRUT, " +
			   "    ZLECENIA.NR_TRAWERSY, " +
			   "    KLIENT.KLIENT, " +
			   "    DOSTAWCA_FARBY.DOSTAWCA_FARBY, " +
			   "    KOLOR_FARBY.KOLOR_FARBY, " +
			   "    TYP_FARBY.TYP_FARBY, " +
			   "    POWIERZCHNIA.POWIERZCHNIA, " +
			   "    PO£YSK.PO£YSK, " +
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
			   "    dbo.PO£YSK AS PO£YSK ON ZLECENIA.ID_PO£YSK = PO£YSK.ID_PO£YSK " +
			   "INNER JOIN " +
			   "    dbo.STATUS_ZLECENIA AS STATUS_ZLECENIA ON ZLECENIA.ID_STATUS = STATUS_ZLECENIA.ID_STATUS " +
			   "WHERE " +
			   "    ZLECENIA.ID_PLANU = @PlanId";

					SqlCommand sqlSelect = new SqlCommand(Select, connection);
					sqlSelect.Parameters.AddWithValue("@PlanId", id);
					using (SqlDataReader reader = sqlSelect.ExecuteReader())
					{
						
						while (reader.Read())
						{
							InfoZlecenPlan infoZlecenPlan = new InfoZlecenPlan();
							infoZlecenPlan.NR_ZLECENIA = reader.GetString(0);
							infoZlecenPlan.DATA_DOSTAWY = reader.GetDateTime(1).ToShortDateString();
							infoZlecenPlan.DATA_REALIZACJI = reader.GetDateTime(2).ToShortDateString();
							infoZlecenPlan.NAZWA_WYROBU = reader.GetString(3);
							infoZlecenPlan.UWAGI = reader.GetString(4);
							infoZlecenPlan.ILOŒÆ_SZTUK = reader.GetDecimal(5).ToString();
							infoZlecenPlan.ILOŒÆ_M2 = reader.GetDecimal(6).ToString();
							infoZlecenPlan.PODK£AD = reader.GetBoolean(7).ToString();
							infoZlecenPlan.ŒRUT = reader.GetBoolean(8).ToString();
							infoZlecenPlan.NR_TRAWERSY = reader.GetDecimal(9).ToString();
							infoZlecenPlan.KLIENT = reader.GetString(10); //
							infoZlecenPlan.DOSTAWCA_FARBY = reader.GetString(11);
							infoZlecenPlan.KOLOR_FARBY = reader.GetString(12);
							infoZlecenPlan.TYP_FARBY = reader.GetString(13);
							infoZlecenPlan.POWIERZCHNIA = reader.GetString(14);
							infoZlecenPlan.POLYSK = reader.GetString(15);
							infoZlecenPlan.STATUS = reader.GetString(16);
							listInfoZlecenPlan.Add(infoZlecenPlan);
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
	public class InfoZlecenPlan
	{
		public String NR_ZLECENIA;
		public String DATA_DOSTAWY;
		public String DATA_REALIZACJI;
		public String NAZWA_WYROBU;
		public String UWAGI;
		public String ILOŒÆ_SZTUK;
		public String ILOŒÆ_M2;
		public String PODK£AD;
		public String POLYSK; //
		public String ŒRUT;
		public String KLIENT; //
		public String NR_TRAWERSY;
		public String DOSTAWCA_FARBY;
		public String KOLOR_FARBY;
		public String TYP_FARBY;
		public String POWIERZCHNIA;
		public String STATUS;
	}
}
