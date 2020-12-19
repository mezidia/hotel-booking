using System.Data.SqlClient;

namespace hotel_booking.SqlConn
{
    class DBSQLServerUtils
    {

        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            //sql connect str
            //Data Source = STRIX\SQLEXPRESS; Initial Catalog = Hotels_DB; Persist Security Info = True; User ID = sa; Password = latroTOP
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }


    }
}