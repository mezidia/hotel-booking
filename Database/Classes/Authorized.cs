using System;
using hotel_booking.SqlConn;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_booking
{
	public class Authorized : User
	{
		// properties

		protected string Email { get; set; }
		protected string Login { get; set; }
		protected string Password { get; set; }

		protected int Age { get; set; }
		protected int PhoneNumber { get; set; }
		protected int Country { get; set; }
		protected int ID { get; set; }

		// methods

		public void Book()
		{

		}

		public void CheckBookings()
		{

		}

		public void Review()
		{

		}

		//input: id of booking
		//output: true if success
		public bool CancelBooking(int id)
		{
			bool funcState = false;

			SqlConnection conn = DBConnConfig.GetDBConnection();
			conn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("CancelBooking", conn);

				// Вид Command является StoredProcedure
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@BookID", SqlDbType.Int).Value = id;

				// Выполнить процедуру.
				cmd.ExecuteNonQuery();

				//output recieved data
				Console.WriteLine("Deleted hotel with id: " + id);

				funcState =  true;
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

		public void ReceiveEmails()
		{

		}

		public void ReportReviews()
		{

		}

		public User LogOut()
		{
			return new Unauthorized();
		}

		//input:  object[country, owner id, rating, description, location, hotel type, hotel name]
		//output: true if data inserted successfully or false if smt went wrong
		public bool AddHotel(object[] hotelFields)
		{
			bool funcState = false;

			SqlConnection conn = DBConnConfig.GetDBConnection();
			conn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("SetHotel", conn);

				//Command type -> StoredProcedure
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@Country", SqlDbType.Int).Value = hotelFields[0];
				cmd.Parameters.Add("@Owner", SqlDbType.Int).Value = hotelFields[1];
				cmd.Parameters.Add("@NumberOfStars", SqlDbType.Int).Value = hotelFields[2];
				cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = hotelFields[3];
				cmd.Parameters.Add("@Location", SqlDbType.Int).Value = hotelFields[4];
				cmd.Parameters.Add("@HotelType", SqlDbType.Int).Value = hotelFields[5];
				cmd.Parameters.Add("@Rating", SqlDbType.Int).Value = hotelFields[6];
				cmd.Parameters.Add("@HotelName", SqlDbType.NVarChar).Value = hotelFields[7];

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
	}
}
