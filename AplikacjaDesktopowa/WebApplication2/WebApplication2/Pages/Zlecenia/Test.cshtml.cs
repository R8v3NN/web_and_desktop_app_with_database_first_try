using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication2.Pages.Zlecenia
{
    public class TestModel : PageModel
	{
		public CommisionInfo commisionInfo = new CommisionInfo();
		public Wartosci wartoscInfo = new Wartosci();
		public List<Wartosci> listWartosciDecimal = new List<Wartosci>();
		public List<DostawcaE> listDostawca = new List<DostawcaE>();
		public List<KolorE> listKolor = new List<KolorE>();
		public List<TypE> listTyp = new List<TypE>();
		public List<PowierzchniaE> listPowierzchnia = new List<PowierzchniaE>();
		public List<PolyskE> listPolysk = new List<PolyskE>();
		public List<KlientE> listKlient = new List<KlientE>();
		public List<StatusE> listStatus = new List<StatusE>();
		public void OnGet()
		{
			String id = Request.Query["id"].ToString();
			String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
			try
			{
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					SqlCommand sqlKlient = new SqlCommand("Select * From [KLIENT]", connection);
					using (SqlDataReader readerKlient = sqlKlient.ExecuteReader())
					{
						while (readerKlient.Read())
						{
							KlientE slownikDanych = new KlientE();
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
							DostawcaE slownikDanych = new DostawcaE();
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
							KolorE slownikDanych = new KolorE();
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
							TypE slownikDanych = new TypE();
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
							PowierzchniaE slownikDanych = new PowierzchniaE();
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
							PolyskE slownikDanych = new PolyskE();
							slownikDanych.PO£YSKID = "" + readerPolysk.GetDecimal(0);
							slownikDanych.PO£YSK = readerPolysk.GetString(1);
							listPolysk.Add(slownikDanych);
						}
					}
					SqlCommand sqlStatus = new SqlCommand("Select * From [STATUS_ZLECENIA]", connection);
					using (SqlDataReader readerStatus = sqlStatus.ExecuteReader())
					{
						while (readerStatus.Read())
						{
							StatusE slownikDanych = new StatusE();
							slownikDanych.STATUSID = "" + readerStatus.GetDecimal(0);
							slownikDanych.STATUS = readerStatus.GetString(1);
							listStatus.Add(slownikDanych);
						}
					}
					String Select = "SELECT [NR_ZLECENIA], [NR_TRAWERSY] ,[DATA_DOSTAWY] ,[DATA_REALIZACJI] ,[NAZWA_WYROBU] ,[UWAGI] ,[ILOŒÆ_SZTUK] , " +
										"[ILOŒÆ_M2] ,[PODK£AD] ,[ŒRUT] ,[STATUS] ,[KLIENT] ,[DOSTAWCA_FARBY] ,[KOLOR_FARBY] ,[TYP_FARBY] ,[POWIERZCHNIA] ,[PO£YSK], [ID_ZLECENIA] FROM [BAZA_MALARNIA].[dbo].[Zecenie] WHERE [ID_ZLECENIA] = @ID";
					using (SqlCommand sqlSelect = new SqlCommand(Select, connection))
					{
						sqlSelect.Parameters.AddWithValue("@ID", id);
						using (SqlDataReader reader = sqlSelect.ExecuteReader())
						{
							while (reader.Read())
							{
								String ilosc = reader.GetDecimal(7).ToString();
					
								Wartosci wartoscDecimal = new Wartosci();
								commisionInfo.NR_ZLECENIA = reader.GetString(0);
								commisionInfo.NR_TRAWERSY = reader.GetDecimal(1).ToString();
								wartoscDecimal.DATA_DOSTAWY = reader.GetDateTime(2).Date;
								wartoscDecimal.DATA_REALIZACJI = reader.GetDateTime(3).Date;
								commisionInfo.NAZWA_WYROBU = reader.GetString(4);
								commisionInfo.UWAGI = reader.GetString(5);
								commisionInfo.ILOŒÆ_SZTUK = reader.GetDecimal(6).ToString();
								commisionInfo.ILOŒÆ_M2 = ilosc.Replace(",", ".");
								wartoscDecimal.PODKLAD = reader.GetBoolean(8);
								wartoscDecimal.SRUT = reader.GetBoolean(9);
								commisionInfo.STATUS = reader.GetString(10);
								commisionInfo.KLIENT = reader.GetString(11);
								commisionInfo.DOSTAWCA_FARBY = reader.GetString(12);
								commisionInfo.KOLOR_FARBY = reader.GetString(13);
								commisionInfo.TYP_FARBY = reader.GetString(14);
								commisionInfo.POWIERZCHNIA = reader.GetString(15);
								commisionInfo.PO£YSK = reader.GetString(16);
								listWartosciDecimal.Add(wartoscDecimal);
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
					String sqlUpdate = "UPDATE [dbo].[ZLECENIA] SET [NR_ZLECENIA] = @NR_ZLECENIA, " +
										"[ID_STATUS] = @ID_STATUS, " +
										"[ID_POWIERZCHNIA] = @ID_POWIERZCHNIA, " +
										"[ID_PO£YSK] = @ID_PO£YSK, " +
										"[ID_KOLOR] = @ID_KOLOR, " +
										"[ID_DOSTAWCA_FARBY] = @ID_DOSTAWCA_FARBY, " +
										"[ID_KLIENT] = @ID_KLIENT, " +
										"[ID_TYP_FARBY] = @ID_TYP_FARBY, " +
										"[DATA_DOSTAWY] = @DATA_DOSTAWY, " +
										"[DATA_REALIZACJI] = @DATA_REALIZACJI, " +
										"[NAZWA_WYROBU] = @NAZWA_WYROBU, " +
										"[UWAGI] = @UWAGI, " +
										"[ILOŒÆ_SZTUK] = @ILOŒÆ_SZTUK, " +
										"[ILOŒÆ_M2] = @ILOŒÆ_M2, " +
										"[PODK£AD] = @PODK£AD, " +
										"[ŒRUT] = @ŒRUT, " +
										"[NR_TRAWERSY] = @NR_TRAWERSY " +
										"WHERE [ID_ZLECENIA] = @ID_ZLECENIA"; 

					using (SqlCommand sqlInsertCommand = new SqlCommand(sqlUpdate, connection))
					{
						int podklad = 0;
						int srut = 0;
						if (Request.Form["PODKLAD"] == "on")
							podklad = 1;
						else podklad = 0;
						if (Request.Form["SRUT"] == "on")
							srut = 1;
						else srut = 0;
						String ilosc = Request.Form["ILOŒÆ_M2"];
						
						sqlInsertCommand.Parameters.AddWithValue("@ID_ZLECENIA", Decimal.Parse(id));

						sqlInsertCommand.Parameters.AddWithValue("@NR_ZLECENIA", Request.Form["NR_ZLECENIA"].ToString());
						sqlInsertCommand.Parameters.AddWithValue("@ID_STATUS", Decimal.Parse(Request.Form["STATUS"]));
						
						sqlInsertCommand.Parameters.AddWithValue("@ID_POWIERZCHNIA", Decimal.Parse(Request.Form["POWIERZCHNIA"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_PO£YSK", Decimal.Parse(Request.Form["POLYSK"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_KOLOR", Decimal.Parse(Request.Form["KOLORFARBY"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_DOSTAWCA_FARBY", Decimal.Parse(Request.Form["DOSTAWCAFARBY"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_KLIENT", Decimal.Parse(Request.Form["KLIENT"]));
						sqlInsertCommand.Parameters.AddWithValue("@ID_TYP_FARBY", Decimal.Parse(Request.Form["TYPFARBY"]));
						
						sqlInsertCommand.Parameters.AddWithValue("@DATA_DOSTAWY", DateTime.Parse(Request.Form["DATA_DOSTAWY"]));
						sqlInsertCommand.Parameters.AddWithValue("@DATA_REALIZACJI", DateTime.Parse(Request.Form["DATA_REALIZACJI"]));
						sqlInsertCommand.Parameters.AddWithValue("@NAZWA_WYROBU", Request.Form["NAZWA_WYROBU"].ToString());
						sqlInsertCommand.Parameters.AddWithValue("@UWAGI", Request.Form["UWAGI"].ToString());
						sqlInsertCommand.Parameters.AddWithValue("@ILOŒÆ_SZTUK", Decimal.Parse(Request.Form["ILOŒÆ_SZTUK"]));
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
	public class Wartosci
	{
		public Decimal NRTRAWERSY;
		public Decimal ILOSCM2;
		public Decimal ILOSCSZT;
		public Boolean SRUT;
		public Boolean PODKLAD;
		public DateTime DATA_DOSTAWY;
		public DateTime DATA_REALIZACJI;
	}
	public class StatusE
	{
		public String? STATUS;
		public String? STATUSID;
	}
		public class PolyskE
	{
		public String? PO£YSK;
		public String? PO£YSKID;
	}
	public class PowierzchniaE
	{
		public String? POWIERZCHNIAID;
		public String? POWIERZCHNIA;
	}
	public class TypE
	{
		public String? TYP_FARBY;
		public String? TYP_FARBYID;
	}
	public class KolorE
	{
		public String? KOLOR_FARBY;
		public String? KOLOR_FARBYID;
	}
	public class DostawcaE
	{
		public String? DOSTAWCA_FARBY;
		public String? DOSTAWCA_FARBYID;
	}
	public class KlientE
	{
		public String? KLIENT;
		public String? KLIENTID;
	}
}