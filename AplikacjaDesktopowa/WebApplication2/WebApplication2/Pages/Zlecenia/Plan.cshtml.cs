using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication2.Pages.Zlecenia
{
    public class PlanModel : PageModel
    {
        public List<InfoPlan> listInfoPlan = new List<InfoPlan>();
        public void OnGet()
        {
            try
            {
                String conectionString = "Data Source = localhost; Initial Catalog = BAZA_MALARNIA; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    String Select = "SELECT * From PLAN_ZLECEN";
                    SqlCommand sqlSelect = new SqlCommand(Select, connection);
                    using (SqlDataReader reader = sqlSelect.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InfoPlan planInfo = new InfoPlan();
                            planInfo.IdPlanu = reader.GetDecimal(0).ToString();
                            planInfo.DataPlanu = reader.GetDateTime(1).ToShortDateString();
                            listInfoPlan.Add(planInfo);
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
    public class InfoPlan
    {
        public String IdPlanu;
        public String DataPlanu;
    }
}
