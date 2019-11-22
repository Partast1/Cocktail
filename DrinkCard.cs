using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail
{
    public class DrinkCard
    {
        public void GetDrinks()
        {
            string connString = @"Server=(localdb)\MSSQLLocalDB;Database=CocktailDataBase;Trusted_Connection = True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Drinks";


                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            Console.WriteLine("{0}", dataReader.GetValue(i));
                            

                            
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }

                conn.Close();
            }

        }
    }
}
