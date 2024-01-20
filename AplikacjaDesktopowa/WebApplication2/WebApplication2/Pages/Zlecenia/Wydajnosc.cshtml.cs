using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication2.Pages.Zlecenia
{
    public class WydajnoscModel : PageModel
    {
		public List<Wydajnosc> listWydajnosc = new List<Wydajnosc>();
		public void OnGet()
		{
			try
			{
				String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
				using (SqlConnection connection = new SqlConnection(conectionString))
				{
					connection.Open();
					String Select = "SELECT [NR_ZLECENIA] , [Wydajnosc_Malowania]  , [Wydajnosc_Podkladu] , [Wydajnosc_Srutowania] , [Wydajnosc_Przygotowania]" +
					"  , [Wydajnosc_Pakowania]  , [Wydajnoœæ_Zu¿ycia_Materia³ów_Malowania] , [Wydajnoœæ_Zu¿ycia_Materia³ów_Podk³ad] FROM [BAZA_MALARNIA].[dbo].[View_1]";
					SqlCommand sqlSelect = new SqlCommand(Select, connection);
					using (SqlDataReader reader = sqlSelect.ExecuteReader())
					{
						while (reader.Read())
						{
							Wydajnosc wydajnosc = new Wydajnosc();
							wydajnosc.NRZLECENIA = reader.GetString(0);
							wydajnosc.WydajnoscPodkladu = reader.IsDBNull(1) ? null : Math.Round(reader.GetDecimal(1), 2).ToString();
							wydajnosc.WydajnoscMalowania = reader.IsDBNull(2) ? null : Math.Round(reader.GetDecimal(2), 2).ToString();
							wydajnosc.WydajnoscSrutowania = reader.IsDBNull(3) ? null : Math.Round(reader.GetDecimal(3), 2).ToString();
							wydajnosc.WydajnoscPrzygotowania = reader.IsDBNull(4) ? null : Math.Round(reader.GetDecimal(4), 2).ToString();
							wydajnosc.WydajnoscPakowania = reader.IsDBNull(5) ? null : Math.Round(reader.GetDecimal(5), 2).ToString();
							wydajnosc.WydajnoscZu¿yciaMateria³ówMalowania = reader.IsDBNull(6) ? null : Math.Round(reader.GetDecimal(6), 2).ToString();
							wydajnosc.WydajnoœæZu¿yciaMateria³ówPodk³ad = reader.IsDBNull(7) ? null : Math.Round(reader.GetDecimal(7), 2).ToString();
							listWydajnosc.Add(wydajnosc);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception: " + ex.ToString());
			}
		}
		public class Wydajnosc
		{
			public String? NRZLECENIA;
			public String? WydajnoscPodkladu;
			public String? WydajnoscMalowania;
			public String? WydajnoscSrutowania;
			public String? WydajnoscPrzygotowania;
			public String? WydajnoscPakowania;
			public String? WydajnoscZu¿yciaMateria³ówMalowania;
			public String? WydajnoœæZu¿yciaMateria³ówPodk³ad;


		}
    }
}
