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

		//input: object[price, roomNumber, tv, roomType, numberOfBeds, balcony, sale]
		//output: true if successful
		
		public bool UpdateRoom(object[] fields)
		{
			bool state;
			SqlConnection conn = DBConnConfig.GetDBConnection();
			conn.Open();
			SqlCommand cmd = new SqlCommand("UpdateRoom", conn);

			// Вид Command является StoredProcedure
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = fields[0];
			cmd.Parameters.Add("@Price", SqlDbType.Int).Value = fields[1];
			cmd.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = fields[2];
			cmd.Parameters.Add("@TV", SqlDbType.Bit).Value = fields[3];
			cmd.Parameters.Add("@RoomType", SqlDbType.NVarChar).Value = fields[4];
			cmd.Parameters.Add("@NumberOfBeds", SqlDbType.Int).Value = fields[5];
			cmd.Parameters.Add("@Balcony", SqlDbType.Bit).Value = fields[6];
			cmd.Parameters.Add("@Sale", SqlDbType.Bit).Value = fields[7];

			// Выполнить процедуру.
			try
			{
				cmd.ExecuteNonQuery();
				state = true;
			}
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
				state = false;
			}
			conn.Close();
			conn.Dispose();
			return state;
		}

		public void CheckHotelBookings()
		{

		}
	}
}