using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication2.Pages.Zlecenia
{
    public class OperacjeModel : PageModel
    {
		public CommisionInfo commisionInfo = new CommisionInfo();
		public List<OperacjeInfo> listOperacji = new List<OperacjeInfo>();
		public void OnGet()
        {
			try
			{
				String id = Request.Query["id"].ToString();
				String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					String Select = "SELECT OPERACJE.NAZWA_OPERACJI, DANE_OPERACJI.DATA_OPERACJI, " +
						"DANE_OPERACJI.CZAS_OPERACJI, DANE_OPERACJI.ZUZYCIE_MATERIALOW, DANE_OPERACJI.ID_OPERACJI " +
						"FROM [BAZA_MALARNIA].[dbo].[DANE_OPERACJI] AS DANE_OPERACJI " +
						"JOIN [BAZA_MALARNIA].[dbo].[ZLECENIA] AS ZLECENIA ON DANE_OPERACJI.ID_ZLECENIA = ZLECENIA.ID_ZLECENIA " +
						"JOIN [BAZA_MALARNIA].[dbo].[OPERACJE] AS OPERACJE ON DANE_OPERACJI.ID_OPERACJI = OPERACJE.ID_OPERACJI " +
						"WHERE ZLECENIA.ID_ZLECENIA = @ID_ZLECENIA";

					SqlCommand sqlSelect = new SqlCommand(Select, connection);
					sqlSelect.Parameters.AddWithValue("@ID_ZLECENIA", id);
					using (SqlDataReader reader = sqlSelect.ExecuteReader())
					{
						while (reader.Read())
						{
							CommisionInfo commisionInfo = new CommisionInfo();
							OperacjeInfo operacje = new OperacjeInfo();
							operacje.NazwaOperacji = reader.GetString(0);
							operacje.DataOperacji = reader.GetDateTime(1).ToShortDateString();
							operacje.CzasOperacji = reader.GetDecimal(2).ToString();
							operacje.ZuzycieMaterialow = reader.GetDecimal(3).ToString();
							operacje.IdOperacji = reader.GetDecimal(4).ToString();
							listOperacji.Add(operacje);
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
	public class OperacjeInfo
	{
		public String? IdOperacji;
		public String? NazwaOperacji;
		public String? DataOperacji;
		public String? CzasOperacji;
		public String? ZuzycieMaterialow;
	}
}
