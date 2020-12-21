using System;
using hotel_booking.SqlConn;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_booking
{
	//input:  object[hotel id, NewOwner id, description, location, hotel type, hotel name]
	//output: true if data inserted successfully or false if smt went wrong
	public class HotelAdmin : Authorized
	{
		// properties
		protected int HotelID { get; }

		// methods
		public bool UpdateHotelInfo(object[] hotelFields)
		{
			bool funcState = false;

			SqlConnection conn = DBConnConfig.GetDBConnection();
			conn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("SetHotel", conn);

				//Command type -> StoredProcedure
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@HotelID", SqlDbType.Int).Value = hotelFields[0];
				cmd.Parameters.Add("@NewOwner", SqlDbType.Int).Value = hotelFields[1];
				cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = hotelFields[2];
				cmd.Parameters.Add("@Location", SqlDbType.Int).Value = hotelFields[3];
				cmd.Parameters.Add("@HotelType", SqlDbType.Int).Value = hotelFields[4];
				cmd.Parameters.Add("@HotelName", SqlDbType.Int).Value = hotelFields[5];
				//exec procedure
				cmd.ExecuteNonQuery();
				funcState = true;
			}
			catch (Exception e)
			{
				//Console.log error
				Console.WriteLine("Error: " + e.Message);
				funcState = false;
			}

			conn.Close();
			conn.Dispose();

			return funcState;
		}

		public void CheckHotelBookings()
		{

		}
	}
}