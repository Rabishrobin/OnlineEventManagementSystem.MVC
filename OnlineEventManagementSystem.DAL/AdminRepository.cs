using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OnlineEventManagementSystem.DAL
{
    public class AdminRepository
    {
        internal static string configurationString = ConfigurationManager.ConnectionStrings["EventManagement"].ConnectionString;
        static SqlConnection connection = null;
        public static DataTable DisplayEvent()
        {
            string procedure = "usp_EventDetails_View";
            DataTable table;
            using (connection = new SqlConnection(configurationString))
            {
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            return table;
        }
        public static void DeleteEvent(string eventID)
        {
            string procedure = "usp_EventDetails_Delete";
            using (connection = new SqlConnection(configurationString))
            {
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("EventID", eventID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void InsertEvent(string eventID, string eventName, string eventType)
        {
            string procedure = "usp_EventDetails_Insert";
            using (connection = new SqlConnection(configurationString))
            {
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EventID", eventID);
                command.Parameters.AddWithValue("@EventName", eventName);
                command.Parameters.AddWithValue("@EventType", eventType);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}