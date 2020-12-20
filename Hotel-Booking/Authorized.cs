using System;
using hotel_booking.SqlConn;
using System.Data.SqlClient;

namespace Hotel_booking
{
	public class Authorized : User
	{
		protected string email;
		protected string login;
		protected string password;

		protected int age;
		protected int phoneNumber;
		protected int country;
		protected int id;
	}
}
