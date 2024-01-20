using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication2.Pages.Zlecenia
{
    public class DodajOperacjeModel : PageModel
    {
		public List<Operacje> listOperacje = new List<Operacje>();
		public void OnGet()
        {
			try
			{
				String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					SqlCommand sqlKlient = new SqlCommand("Select * From [OPERACJE]", connection);
					using (SqlDataReader readerKlient = sqlKlient.ExecuteReader())
					{
						while (readerKlient.Read())
						{
							Operacje slownikDanych = new Operacje();
							slownikDanych.OPERACJAID = "" + readerKlient.GetDecimal(0);
							slownikDanych.OPERACJA = readerKlient.GetString(1);
							listOperacje.Add(slownikDanych);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception: " + ex.ToString());
			}
		}
		public void OnPost()
		{
			String id = Request.Query["id"].ToString();
			try
			{
				String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					String sqlInsert = "INSERT INTO DANE_OPERACJI ([ID_ZLECENIA], [ID_OPERACJI], [DATA_OPERACJI], [CZAS_OPERACJI]," +
				" [ZUZYCIE_MATERIALOW]) VALUES (@ID_ZLECENIA, @IDOPERACJI, @DATAOPERACJI,  @CZASOPERACJI, @ZUZYCIEMAT)";
					using (SqlCommand sqlInsertCommand = new SqlCommand(sqlInsert, connection))
					{
						String ilosc = Request.Form["ZUZYCIEMATERIALOW"];
						String test = ilosc.Replace(".", ",");
						sqlInsertCommand.Parameters.AddWithValue("@ID_ZLECENIA", Decimal.Parse(id));
						sqlInsertCommand.Parameters.AddWithValue("@IDOPERACJI", Decimal.Parse(Request.Form["OPERACJA"]));
						sqlInsertCommand.Parameters.AddWithValue("@DATAOPERACJI", DateTime.Parse(Request.Form["DATA_OPERACJI"]).Date);
						sqlInsertCommand.Parameters.AddWithValue("@CZASOPERACJI", Decimal.Parse(Request.Form["CZAS_OPERACJI"]));
						sqlInsertCommand.Parameters.AddWithValue("@ZUZYCIEMAT", Decimal.Parse(test));

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
 

	public class Operacje
	{
		public String? OPERACJA;
		public String? OPERACJAID;
	}
}
