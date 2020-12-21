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

//input: id of room
//output: object[hotel id, price, room number, freee dates, tv, room type, number of beds, balcony, sale
public object GetRoom(int id)
    {
        SqlConnection conn = DBConnConfig.GetDBConnection();
        conn.Open();
        SqlCommand cmd = new SqlCommand("GetRoom", conn);
 
        // Вид Command является StoredProcedure
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = id;
  
        // Выполнить процедуру.
        cmd.ExecuteNonQuery();

        object[] HotelData = new object[9];

        using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    HotelData[0] = int.Parse(rdr["hotel_id"].ToString());
                    HotelData[1] = int.Parse(rdr["price_int"].ToString());
                    HotelData[2] = int.Parse(rdr["roomNumber_int"].ToString());
                    HotelData[3] = int.Parse(rdr["freeDates_int"].ToString());
                    HotelData[4] = bool.Parse(rdr["TV_bool"].ToString());
                    HotelData[5] = rdr["roomType_str"].ToString();
                    HotelData[6] = int.Parse(rdr["numberOfBeds_int"].ToString());
                    HotelData[7] = bool.Parse(rdr["balcony_bool"].ToString());
                    HotelData[8] = bool.Parse(rdr["sale_bool"].ToString());
                }
            } 
        //output recieved data
        Console.WriteLine("hotel id: " + HotelData[0]);
        Console.WriteLine("price int: " + HotelData[1]);
        Console.WriteLine("room number: " + HotelData[2]);
        Console.WriteLine("free dates: " + HotelData[3]);
        Console.WriteLine("tv: " + HotelData[4]);
        Console.WriteLine("room type: " + HotelData[5]);
        Console.WriteLine("number of beds: " + HotelData[6]);
        Console.WriteLine("balcony: " + HotelData[7]);
        Console.WriteLine("sale: " + HotelData[8]);
        conn.Close();
        conn.Dispose();
        return HotelData;
    }
		


        //input: id of user
        //output: object[country, permission, phoneNumber, email, login, userName, age, password]
        public object[] GetUser(int id)
		{
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();

            object[] UserData = new object[8];

            try
            {
                SqlCommand cmd = new SqlCommand("GetUser", conn);

                //Command type -> StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = id;

                //exec procedure
                cmd.ExecuteNonQuery();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        UserData[0] = int.Parse(rdr["country_id"].ToString());
                        UserData[1] = int.Parse(rdr["permission_int"].ToString());
                        UserData[2] = int.Parse(rdr["phoneNumber_int"].ToString());
                        UserData[3] = rdr["email_str"].ToString();
                        UserData[4] = rdr["login_str"].ToString();
                        UserData[5] = rdr["userName_str"].ToString();
                        UserData[6] = int.Parse(rdr["age_int"].ToString());
                        UserData[7] = rdr["password_str"].ToString();
                    }
                }
                //output recieved data
                Console.WriteLine("country id : " + UserData[0]);
                Console.WriteLine("permission : " + UserData[1]);
                Console.WriteLine("phoneNumber : " + UserData[2]);
                Console.WriteLine("email : " + UserData[3]);
                Console.WriteLine("userName : " + UserData[4]);
                Console.WriteLine("hotel type: " + UserData[5]);
                Console.WriteLine("age : " + UserData[6]);
                Console.WriteLine("password : " + UserData[7]);
            }
            catch (Exception e)
            {
                //Console.log error
                Console.WriteLine("Error: " + e.Message);
            }

            //close conn
            conn.Close();
            conn.Dispose();


        }

        //input: id of hotel
        //output: object[country, owner id, rating, description, location, hotel type, hotel name]
        public object GetHotel(int id)
        {
            SqlConnection conn = DBConnConfig.GetDBConnection();
            conn.Open();

            object[] HotelData = new object[8];

            try
            {
                SqlCommand cmd = new SqlCommand("GetHotel", conn);

                //Command type -> StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@HotelID", SqlDbType.Int).Value = id;

                //exec procedure
                cmd.ExecuteNonQuery();

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
            } catch (Exception e)
            {
                //Console.log error
                Console.WriteLine("Error: " + e.Message);
            }

            //close conn
            conn.Close();
            conn.Dispose();

            return HotelData;
        }
    }
}
