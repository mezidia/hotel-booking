using System.Data.SqlClient;

namespace hotel_booking.SqlConn
{
    class DBConnConfig
    {
        public static SqlConnection GetDBConnection()
        {
            //sql connect str
            //Data Source = STRIX\SQLEXPRESS; Initial Catalog = Hotels_DB; Persist Security Info = True; User ID = sa; Password = latroTOP
            string datasource = @"STRIX\SQLEXPRESS";

            string database = "Hotels_DB";
            string username = "sa";
            string password = "latroTOP";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}
