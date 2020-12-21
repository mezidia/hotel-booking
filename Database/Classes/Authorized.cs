using System;
using hotel_booking.SqlConn;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_booking
{
	public class Authorized : User
	{
		// properties

		public string Email { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public int Age { get; set; }
		public int PhoneNumber { get; set; }
		public int Country { get; set; }
		public int ID { get; set; }
		public int Permission { get; set; }

		// methods

		//input:  object[book id, user id, room id, description str, start date, end date]
		//output: true if book created successfully or false if smt went wrong
		public bool Book(object[] bookfields)
		{
			bool funcState = false;

			SqlConnection conn = DBConnConfig.GetDBConnection();
			conn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("SetBooking", conn);

				//Command type -> StoredProcedure
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@Book", SqlDbType.Int).Value = bookfields[0];
				cmd.Parameters.Add("@User", SqlDbType.Int).Value = bookfields[1];
				cmd.Parameters.Add("@Room", SqlDbType.Int).Value = bookfields[2];
				cmd.Parameters.Add("@Description_str", SqlDbType.NVarChar).Value = bookfields[3];
				cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = bookfields[4];
				cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = bookfields[5];

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

		//input:  book id
		//output: object[book id, user id, room id, description str, start date, end date]
		public object[] CheckBookings(int id)
		{
			SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetBooking", conn);

            // Вид Command является StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = id;

            // Выполнить процедуру.
            cmd.ExecuteNonQuery();

            object[] UserBookings = new object[9];

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    UserBookings[0] = int.Parse(rdr["book_id"].ToString());
                    UserBookings[1] = int.Parse(rdr["user_id"].ToString());
                    UserBookings[2] = int.Parse(rdr["room_id"].ToString());
                    UserBookings[3] = rdr["description_str"].ToString();
		    UserBookings[4] = int.Parse(rdr["startDate_int"].ToString());
                    UserBookings[5] = int.Parse(rdr["endDate_int"].ToString());
                }
            }
            //output recieved data
            Console.WriteLine("Book id: " + UserBookings[0]);
            Console.WriteLine("User id: " + UserBookings[1]);
            Console.WriteLine("Room id: " + UserBookings[2]);
            Console.WriteLine("Description: " + UserBookings[3]);
            Console.WriteLine("Start date: " + UserBookings[4]);
            Console.WriteLine("End date: " + UserBookings[5]);

            conn.Close();
            conn.Dispose();

            return UserBookings;
		}
		//input: object[UserID, HotelID, Rating, Review, CreationDate]
		//output: true if review created successfully or false if smt went wrong
		public bool Review(object[] reviewfields)
		{
			bool funcState = false;

			SqlConnection conn = DBConnConfig.GetDBConnection();
			conn.Open();

			try
			{
				SqlCommand cmd = new SqlCommand("SetReview", conn);

				//Command type -> StoredProcedure
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = reviewfields[0];
				cmd.Parameters.Add("@HotelID", SqlDbType.Int).Value = reviewfields[1];
				cmd.Parameters.Add("@Rating", SqlDbType.Int).Value = reviewfields[2];
				cmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = reviewfields[3];
				cmd.Parameters.Add("@CreationDate", SqlDbType.DateTime).Value = reviewfields[4];

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

		//input: book id
		//output: true if book canceled successfully or false if smt went wrong
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

			SqlCommand cmd = new SqlCommand("SetHotel", conn);

			// Вид Command является StoredProcedure
			cmd.CommandType = CommandType.StoredProcedure;
			//cmd.Parameters.Add("@HotelID", SqlDbType.Int).Value = id;

			// Выполнить процедуру.
			cmd.ExecuteNonQuery();


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

			//output recieved data
			Console.WriteLine("country: " + HotelData[0]);
			Console.WriteLine("owner id: " + HotelData[1]);
			Console.WriteLine("number of stars: " + HotelData[2]);
			Console.WriteLine("description: " + HotelData[3]);
			Console.WriteLine("location: " + HotelData[4]);
			Console.WriteLine("hotel type: " + HotelData[5]);
			Console.WriteLine("rating: " + HotelData[6]);
			Console.WriteLine("hotel name: " + HotelData[7]);
			return true;


			conn.Close();
			conn.Dispose();

			return funcState;

		}
	}
}
