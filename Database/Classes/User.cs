using System;
using System.Collections.Generic;
using System.Text;
using hotel_booking.SqlConn;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_booking
{
	public class User
	{
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

		public int CheckDeals()
		{


			return 0;
		}

		public object SearchForInfo(object[] fields)
		{
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SearchForInfo", conn);

            // Вид Command является StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CountryId", SqlDbType.Int).Value = fields[0];
            cmd.Parameters.Add("@NumberOfStars", SqlDbType.Int).Value = fields[1];
            cmd.Parameters.Add("@HotelType", SqlDbType.Int).Value = fields[2];
            cmd.Parameters.Add("@Rating", SqlDbType.Int).Value = fields[3];

            // Выполнить процедуру.
            cmd.ExecuteNonQuery();
            object[] hotels = new object[1];

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    hotels[0] = int.Parse(rdr["hotel_id"].ToString());
                }
            }
            //output recieved data
            Console.WriteLine("hotel: " + hotels[0]);
            return hotels[0];
        }
	}
}
