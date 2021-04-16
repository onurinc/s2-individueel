using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PlannerWebApplicationV2.Models;

namespace PlannerWebApplicationV2.HelperClasses
{
    public class UserRegistrationClass
    {
        public static string connectionstring =
            @"Data Source=DESKTOP-A6O4P0A\SQLEXPRESS;Initial Catalog=Projects;Integrated Security=True";
        public static void UserRegistration(UserModel user)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                string sqlQuery =
                    "INSERT INTO User2([Username], [Email], [Password], [Firstname], [Middlename], [Lastname]) VALUES (@username, @email, @password, @firstname, @middlename, @lastname);";

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery,sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.AddWithValue("@username", user.Username);
                    sqlCommand.Parameters.AddWithValue("@email", user.Email);
                    sqlCommand.Parameters.AddWithValue("@password", user.Password);
                    sqlCommand.Parameters.AddWithValue("@firstname", user.Firstname);
                    sqlCommand.Parameters.AddWithValue("@middlename", user.Middlename);
                    sqlCommand.Parameters.AddWithValue("@lastname", user.Lastname);
                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
            }
        }
    }
}
