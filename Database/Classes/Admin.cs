using hotel_booking.SqlConn;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_booking
{
	public class Admin : Authorized
	{
		// methods
		public bool ChangePermissions(int id, int permission)
		{
			SqlConnection conn = DBConnConfig.GetDBConnection();
			conn.Open();
			SqlCommand cmd = new SqlCommand("ChangePermissions", conn);

			// Вид Command является StoredProcedure
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = id;
			cmd.Parameters.Add("@Permissions", SqlDbType.Int).Value = permission;
			// Выполнить процедуру.
			int countChangedRows = cmd.ExecuteNonQuery();
			return countChangedRows == 1;
		}

		
		public void ContentModeration()
		{

		}

		public void UsersSupport()
		{

		}
	}
}