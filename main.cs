using System;
using hotel_booking.SqlConn;
using System.Data.SqlClient;
using Hotel_booking;

namespace ConnectSQLServer
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting sql Connection ...");
            SqlConnection conn = DBConnConfig.GetDBConnection();

            try
            {
                Console.WriteLine("Openning sql Connection ...");

                conn.Open();
                //input:  object[country, owner id, rating, description, location, hotel type, hotel name]
                //output: true if data inserted successfully or false if smt went wrong
                object[] hotelDataToInsert = new object[8];
                hotelDataToInsert[0] = 1;
                hotelDataToInsert[1] = 1;
                hotelDataToInsert[2] = 2;
                hotelDataToInsert[3] = "description";
                hotelDataToInsert[4] = 155;
                hotelDataToInsert[5] = 1;
                hotelDataToInsert[6] = 1;
                hotelDataToInsert[7] = "hotel name";

                DBSystem sys = new DBSystem();
                Authorized user = new Authorized();

                sys.GetHotel(1);
                user.AddHotel(hotelDataToInsert);



                Console.WriteLine("Connection to the Hotel_DB was successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }

}
