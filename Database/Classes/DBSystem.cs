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

		public void GetUser()
		{

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
