using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;


namespace WebApplication2.Pages.Zlecenia
{
	
	public class EdytujOperacjeModel : PageModel
    {
		public OperacjeInfo operacjeInfo = new OperacjeInfo();
		public List<OperacjeZmienne> listOperacjeZmienne = new List<OperacjeZmienne>();
		public void OnGet()
        {
			String id = Request.Query["id"].ToString();
			String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
			try
			{
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					String Select = "SELECT OPERACJE.NAZWA_OPERACJI, DANE_OPERACJI.DATA_OPERACJI, " +
						"DANE_OPERACJI.CZAS_OPERACJI, DANE_OPERACJI.ZUZYCIE_MATERIALOW, DANE_OPERACJI.ID_OPERACJI " +
						"FROM [BAZA_MALARNIA].[dbo].[DANE_OPERACJI] AS DANE_OPERACJI " +
						"JOIN [BAZA_MALARNIA].[dbo].[ZLECENIA] AS ZLECENIA ON DANE_OPERACJI.ID_ZLECENIA = ZLECENIA.ID_ZLECENIA " +
						"JOIN [BAZA_MALARNIA].[dbo].[OPERACJE] AS OPERACJE ON DANE_OPERACJI.ID_OPERACJI = OPERACJE.ID_OPERACJI " +
						"WHERE DANE_OPERACJI.ID_OPERACJI = @ID_OPERACJI";
					using (SqlCommand sqlSelect = new SqlCommand(Select, connection))
					{
						sqlSelect.Parameters.AddWithValue("@ID_OPERACJI", id);
						using (SqlDataReader reader = sqlSelect.ExecuteReader())
						{
							while (reader.Read())
							{
								String ilosc = reader.GetDecimal(3).ToString();
								OperacjeZmienne operacjeNew = new OperacjeZmienne();
								operacjeInfo.NazwaOperacji = reader.GetString(0);
								operacjeNew.DataOperacji = reader.GetDateTime(1).Date;
								operacjeInfo.CzasOperacji = reader.GetDecimal(2).ToString();
								operacjeInfo.ZuzycieMaterialow = ilosc.Replace(",", ".");
								listOperacjeZmienne.Add(operacjeNew);


							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}
		public void OnPost()
		{
			try
			{
				String id = Request.Query["id"].ToString();
				String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					String sqlUpdate = "UPDATE [dbo].[DANE_OPERACJI] SET [DATA_OPERACJI] = @DATA_OPERACJI, " +
										"[CZAS_OPERACJI] = @CZAS_OPERACJI, " +
										"[ZUZYCIE_MATERIALOW] = @ZUZYCIE_MATERIALOW " +
										"WHERE [ID_OPERACJI] = @ID_OPERACJI";
					using (SqlCommand sqlInsertCommand = new SqlCommand(sqlUpdate, connection))
					{
						String ilosc = Request.Form["ZuzycieMaterialow"];

						sqlInsertCommand.Parameters.AddWithValue("@ID_OPERACJI", Decimal.Parse(id));
						sqlInsertCommand.Parameters.AddWithValue("@DATA_OPERACJI", DateTime.Parse(Request.Form["DataOperacji"]));
						sqlInsertCommand.Parameters.AddWithValue("@CZAS_OPERACJI", Decimal.Parse(Request.Form["CzasOperacji"]));
						sqlInsertCommand.Parameters.AddWithValue("@ZUZYCIE_MATERIALOW", Decimal.Parse(ilosc.Replace(".", ",")));
						sqlInsertCommand.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception: " + ex.ToString());
			}
			Response.Redirect("/Index");
		}
    }

	public class OperacjeZmienne
	{
		public DateTime DataOperacji;
	}
}
