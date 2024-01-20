using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication2.Pages.Zlecenia
{
    public class CreateModel : PageModel
	{
		public List<Dostawca> listDostawca = new List<Dostawca>();
		public List<Kolor> listKolor = new List<Kolor>();
		public List<Typ> listTyp = new List<Typ>();
		public List<Powierzchnia> listPowierzchnia = new List<Powierzchnia>();
		public List<Polysk> listPolysk = new List<Polysk>();
		public List<Klient> listKlient = new List<Klient>();
		public CommisionInfo commisionInfo = new CommisionInfo();
		public String errorMessage = "";
		public void OnGet()
		{
			try
			{
				String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					SqlCommand sqlKlient = new SqlCommand("Select * From [KLIENT]", connection);
					using (SqlDataReader readerKlient = sqlKlient.ExecuteReader())
					{
						while (readerKlient.Read())
						{
							Klient slownikDanych = new Klient();
							slownikDanych.KLIENTID = "" + readerKlient.GetDecimal(0);
							slownikDanych.KLIENT = readerKlient.GetString(1);
							listKlient.Add(slownikDanych);
						}
					}
					SqlCommand sqlDostawca = new SqlCommand("Select * From [DOSTAWCA_FARBY]", connection);
					using (SqlDataReader readerDostawca = sqlKlient.ExecuteReader())
					{
						while (readerDostawca.Read())
						{
							Dostawca slownikDanych = new Dostawca();
							slownikDanych.DOSTAWCA_FARBYID = "" + readerDostawca.GetDecimal(0);
							slownikDanych.DOSTAWCA_FARBY = readerDostawca.GetString(1);
							listDostawca.Add(slownikDanych);
						}
					}
					SqlCommand sqlKolor = new SqlCommand("Select * From [KOLOR_FARBY]", connection);
					using (SqlDataReader readerKolor = sqlKolor.ExecuteReader())
					{
						while (readerKolor.Read())
						{
							Kolor slownikDanych = new Kolor();
							slownikDanych.KOLOR_FARBYID = "" + readerKolor.GetDecimal(0);
							slownikDanych.KOLOR_FARBY = readerKolor.GetString(1);
							listKolor.Add(slownikDanych);
						}
					}
					SqlCommand sqlTypFarby = new SqlCommand("Select * From [TYP_FARBY]", connection);
					using (SqlDataReader readerTypFarby = sqlTypFarby.ExecuteReader())
					{
						while (readerTypFarby.Read())
						{
							Typ slownikDanych = new Typ();
							slownikDanych.TYP_FARBYID = "" + readerTypFarby.GetDecimal(0);
							slownikDanych.TYP_FARBY = readerTypFarby.GetString(1);
							listTyp.Add(slownikDanych);
						}
					}
					SqlCommand sqlPowierzchnia = new SqlCommand("Select * From [POWIERZCHNIA]", connection);
					using (SqlDataReader readerPowierzchnia = sqlPowierzchnia.ExecuteReader())
					{
						while (readerPowierzchnia.Read())
						{
							Powierzchnia slownikDanych = new Powierzchnia();
							slownikDanych.POWIERZCHNIAID = "" + readerPowierzchnia.GetDecimal(0);
							slownikDanych.POWIERZCHNIA = readerPowierzchnia.GetString(1);
							listPowierzchnia.Add(slownikDanych);
						}
					}
					SqlCommand sqlPolysk = new SqlCommand("Select * From [PO£YSK]", connection);
					using (SqlDataReader readerPolysk = sqlPolysk.ExecuteReader())
					{
						while (readerPolysk.Read())
						{
							Polysk slownikDanych = new Polysk();
							slownikDanych.PO£YSKID = "" + readerPolysk.GetDecimal(0);
							slownikDanych.PO£YSK = readerPolysk.GetString(1);
							listPolysk.Add(slownikDanych);
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
			try
			{
				String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					String sqlInsert = "INSERT INTO ZLECENIA ([ID_STATUS],[ID_POWIERZCHNIA], [ID_PO£YSK], [ID_KOLOR], [ID_DOSTAWCA_FARBY], [ID_KLIENT], [ID_TYP_FARBY]," +
					" [NR_ZLECENIA], [DATA_DOSTAWY], [DATA_REALIZACJI], [NAZWA_WYROBU], [UWAGI], [ILOŒÆ_SZTUK], [ILOŒÆ_M2], [PODK£AD], [ŒRUT], [NR_TRAWERSY]) " +
					"VALUES (@ID_STATUS, @ID_POWIERZCHNIA, @ID_PO£YSK, @ID_KOLOR, @ID_DOSTAWCA_FARBY, @ID_KLIENT, @ID_TYP_FARBY, @NR_ZLECENIA, @DATA_DOSTAWY, @DATA_REALIZACJI, " +
					"@NAZWA_WYROBU, @UWAGI, @ILOŒÆ_SZTUK, @ILOŒÆ_M2, @PODK£AD, @ŒRUT, @NR_TRAWERSY)";
					using (SqlCommand sqlInsertCommand = new SqlCommand(sqlInsert, connection))
					{
						int oczekiwanie = 1;
						int podklad = 0;
						int srut = 0;
						if (Request.Form["PODKLAD"] == "on")
							podklad = 1;
						else podklad = 0;
						if (Request.Form["SRUT"] == "on")
							srut = 1;
						else srut = 0;
						String ilosc = Request.Form["ILOSC_M2"];

						sqlInsertCommand.Parameters.AddWithValue("@ID_STATUS", oczekiwanie);
						sqlInsertCommand.Parameters.AddWithValue("@ID_POWIERZCHNIA", Decimal.Parse(Request.Form["POWIERZCHNIA"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_PO£YSK", Decimal.Parse(Request.Form["POLYSK"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_KOLOR", Decimal.Parse(Request.Form["KOLORFARBY"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_DOSTAWCA_FARBY", Decimal.Parse(Request.Form["DOSTAWCAFARBY"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_KLIENT", Decimal.Parse(Request.Form["KLIENT"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_TYP_FARBY", Decimal.Parse(Request.Form["TYPFARBY"]));
						sqlInsertCommand.Parameters.AddWithValue("@NR_ZLECENIA", Request.Form["NR_ZLECENIA"].ToString());
						sqlInsertCommand.Parameters.AddWithValue("@DATA_DOSTAWY", DateTime.Parse(Request.Form["DATA_DOSTAWY"]));
						sqlInsertCommand.Parameters.AddWithValue("@DATA_REALIZACJI", DateTime.Parse(Request.Form["DATA_REALIZACJI"]));
						sqlInsertCommand.Parameters.AddWithValue("@NAZWA_WYROBU", Request.Form["NAZWA_WYROBU"].ToString());
						sqlInsertCommand.Parameters.AddWithValue("@UWAGI", Request.Form["UWAGI"].ToString());
						sqlInsertCommand.Parameters.AddWithValue("@ILOŒÆ_SZTUK", Decimal.Parse(Request.Form["ILOSC_SZTUK"]));
						sqlInsertCommand.Parameters.AddWithValue("@ILOŒÆ_M2", Decimal.Parse(ilosc.Replace(".", ",")));
						sqlInsertCommand.Parameters.AddWithValue("@PODK£AD", podklad);
						sqlInsertCommand.Parameters.AddWithValue("@ŒRUT", srut);
						sqlInsertCommand.Parameters.AddWithValue("@NR_TRAWERSY", Decimal.Parse(Request.Form["NR_TRAWERSY"]));

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

	public class Polysk
	{
		public String? PO£YSK;
		public String? PO£YSKID;
	}
	public class Powierzchnia
	{
		public String? POWIERZCHNIAID;
		public String? POWIERZCHNIA;
	}
	public class Typ
	{
		public String? TYP_FARBY;
		public String? TYP_FARBYID;
	}
	public class Kolor
	{
		public String? KOLOR_FARBY;
		public String? KOLOR_FARBYID;
	}
	public class Dostawca
	{
		public String? DOSTAWCA_FARBY;
		public String? DOSTAWCA_FARBYID;
	}
	public class Klient
	{
		public String? KLIENT;
		public String? KLIENTID;
	}
}
