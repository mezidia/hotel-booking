using System;
using hotel_booking.SqlConn;
using System.Data.SqlClient;

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
