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


        //input: object[CountryId, NumberOfStars, tv, HotelType, Rating, Sale]
        //output: true if successful
        public object SearchForInfo(object[] fields)
		{
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SearchForInfo", conn);

            // ��� Command �������� StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CountryId", SqlDbType.Int).Value = fields[0];
            cmd.Parameters.Add("@NumberOfStars", SqlDbType.Int).Value = fields[1];
            cmd.Parameters.Add("@HotelType", SqlDbType.Int).Value = fields[2];
            cmd.Parameters.Add("@Rating", SqlDbType.Int).Value = fields[3];
            cmd.Parameters.Add("@Sale", SqlDbType.Int).Value = fields[4];

            // ��������� ���������.
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
