using System.Data;
using System.Data.SqlClient;

namespace Server.Lib.Common
{
    public class SqlHelperAdd
    {
        public static DataTable ExecuteSql(
            string dbConnectionString,
            string sqlString)
        {
            // execute stored procedure
            using (var conn = new SqlConnection(dbConnectionString))
            {
				conn.Open();

				using (var ds = new DataSet())
				using (var da = new SqlDataAdapter(sqlString, conn))
				{
					da.SelectCommand.CommandTimeout = 5;
					ds.Reset();
					da.Fill(ds);

					return ds.Tables[0];
				}
            }
        }
    }
}
