using System;
using System.Collections.Generic;
using System.Text;
using hotel_booking.SqlConn;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_booking
{
	class DBSystem
	{
		// methods
		public void GetReviews()
		{

		}

		public void GetRooms()
		{

		}

		public void GetUser(int id)
		{
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetUser", conn);

            // Вид Command является StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = id;

            // Выполнить процедуру.
            cmd.ExecuteNonQuery();

            object[] UserData = new object[9];

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    UserData[0] = int.Parse(rdr["user_id"].ToString());
                    UserData[1] = int.Parse(rdr["country_id"].ToString());
                    UserData[2] = int.Parse(rdr["permission_int"].ToString());
                    UserData[3] = int.Parse(rdr["phoneNumber_int"].ToString());
                    UserData[4] = rdr["email_str"].ToString();
                    UserData[5] = rdr["login_str"].ToString();
                    UserData[6] = rdr["userName_str"].ToString();
                    UserData[7] = int.Parse(rdr["age_int"].ToString());
                    UserData[8] = rdr["password_str"].ToString();
                }
            }
            //output recieved data
            Console.WriteLine("User id: " + HotelData[0]);
            Console.WriteLine("Country id: " + HotelData[1]);
            Console.WriteLine("Permission: " + HotelData[2]);
            Console.WriteLine("Phone number: " + HotelData[3]);
            Console.WriteLine("Email: " + HotelData[4]);
            Console.WriteLine("Login: " + HotelData[5]);
            Console.WriteLine("Username: " + HotelData[6]);
            Console.WriteLine("Age: " + HotelData[7]);
            Console.WriteLine("Password: " + HotelData[7]);

            conn.Close();
            conn.Dispose();

            return UserData;
		}

        //input: id of hotel
        //output: object[country, owner id, rating, description, location, hotel type, hotel name]
        public object GetHotel(int id)
        {
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetHotel", conn);

            // Вид Command является StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@HotelID", SqlDbType.Int).Value = id;

            // Выполнить процедуру.
            cmd.ExecuteNonQuery();

            object[] HotelData = new object[8];

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    HotelData[0] = int.Parse(rdr["country_id"].ToString());
                    HotelData[1] = int.Parse(rdr["owner_id"].ToString());
                    HotelData[2] = int.Parse(rdr["number_of_stars_int"].ToString());
                    HotelData[3] = rdr["description_str"].ToString();
                    HotelData[4] = int.Parse(rdr["location_int"].ToString());
                    HotelData[5] = int.Parse(rdr["hotelType_int"].ToString());
                    HotelData[6] = int.Parse(rdr["rating_int"].ToString());
                    HotelData[7] = rdr["hotelName_str"].ToString();
                }
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
            return HotelData;
        }
    }
}
