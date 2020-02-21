using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using OnlineEventManagementSystem.Entity;

namespace OnlineEventManagementSystem.DAL
{
    public class UserRepository
    {
        //internal static string configurationString = ConfigurationManager.ConnectionStrings["EventManagement"].ConnectionString;
        //SqlConnection sqlConnection = new SqlConnection(configurationString);
        public void InsertUser(UserManager userManager)
        {
            //string DBConnection = ConfigurationManager.ConnectionStrings["EventManagement"].ConnectionString;
            //using (SqlConnection connection = new SqlConnection(DBConnection))
            //{
            //    connection.Open();
            //    string procedureString = "SP_Insert_User";        //Stored procedure to insert user
            //    SqlCommand sqlCommand = new SqlCommand(procedureString, connection);
            //    sqlCommand.CommandType = CommandType.StoredProcedure;
            //    sqlCommand.Parameters.Add(new SqlParameter("@ID", userManager.UserID));                         //Passing ID to the stored procedure
            //    sqlCommand.Parameters.Add(new SqlParameter("@MailID", userManager.UserMailId));                 //Passing mail id to the stored procedure
            //    sqlCommand.Parameters.Add(new SqlParameter("@Password", userManager.UserPassword));             //Passing password to the stored procedure
            //    sqlCommand.Parameters.Add(new SqlParameter("@FirstName", userManager.UserFirstName));           //Passing first name to the stored procedure
            //    sqlCommand.Parameters.Add(new SqlParameter("@LastName", userManager.UserLastName));             //Passing last name to the stored procedure
            //    sqlCommand.Parameters.Add(new SqlParameter("@MobileNumber", userManager.UserMobileNumber));     //Passing mobile number to the stored procedure
            //    sqlCommand.Parameters.Add(new SqlParameter("@DateOfBirth", userManager.UserDOB));               //Passing dob to the stored procedure
            //    sqlCommand.Parameters.Add(new SqlParameter("@Gender", userManager.UserGender));                 //Passing gender to the stored procedure
            //    sqlCommand.ExecuteNonQuery();
            //    sqlCommand.Dispose();
            //}
        }
        //internal void DeleteUser(string id)
        //{
        //    connection.Open();
        //    string procedureString = "SP_Insert_Delete";                                    //Stored procedure to delete user
        //    SqlCommand sqlCommand = new SqlCommand(procedureString, connection);
        //    sqlCommand.Parameters.Add(new SqlParameter("@ID", id));                         //Passing ID to the stored procedure
        //    sqlCommand.ExecuteNonQuery();
        //    sqlCommand.Dispose();
        //    connection.Close();
        //}
        //internal void UpdateDetails(string id, int choice, dynamic updatingfield)
        //{

        //}
        //internal void DisplayUser()
        //{
        //    connection.Open();
        //    string procedureString = "Select * From UserAccountDetails";
        //    SqlCommand sqlCommand = new SqlCommand(procedureString, connection);
        //    // = sqlCommand.ExecuteReader();

        //    connection.Close();

        //}
    }
}
