using BusinessLibrary.DI;
using BusinessLibrary.Models;
using System.Data.SqlClient;

namespace DB
{
    public class SqlContext : IEmployeer
    {
        private string strConnection = "Data Source=DESKTOP-5RNEI0T;Initial Catalog=Csla;Integrated Security=True";

        public bool CreateEmployeer(Employeer employeer)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command =
                        new SqlCommand($"INSERT INTO Employee (FirstName, LastName, Email) VALUES ('{employeer.FirstName}','{employeer.LastName}','{employeer.Email}')", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (System.Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
                return false;
            }
        }

        public Employeer GetEmployeer(int id)
        {

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                Employeer employeer = new Employeer();
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand($"SELECT * FROM Employee Where Id={id}", connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            employeer.Id = reader.GetInt32(0);
                            employeer.FirstName = reader.GetString(1);
                            employeer.LastName = reader.GetString(2);
                            employeer.Email = reader.GetString(3);
                        }
                    }

                    return employeer;
                }
                catch (System.Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }

                return null;
            }
        }
    }
}
