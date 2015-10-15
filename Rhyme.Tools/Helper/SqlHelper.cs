using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Rhyme.Tools.Helper
{
    public class SqlHelper
    {
        public static SqlParameter ToSqlInParam(string name, Guid value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                SqlDbType = SqlDbType.UniqueIdentifier,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, Guid? value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value ?? (object)DBNull.Value,
                SqlDbType = SqlDbType.UniqueIdentifier,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, TimeSpan? value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value ?? (object)DBNull.Value,
                SqlDbType = SqlDbType.Time,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, long value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                SqlDbType = SqlDbType.BigInt,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, byte value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, int value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, int? value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value ?? (object)DBNull.Value,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            };
        }

		public static SqlParameter ToSqlInParam(string name, decimal? value)
		{
			return new SqlParameter
			{
				ParameterName = name,
				Value = value ?? (object)DBNull.Value,
				SqlDbType = SqlDbType.Decimal,
				Direction = ParameterDirection.Input,
			};
		}

		// Add by dhjang
		public static SqlParameter ToSqlInParam(string name, TimeSpan value)
		{
			return new SqlParameter
			{
				ParameterName = name,
				Value = value,
				SqlDbType = SqlDbType.Time,
				Direction = ParameterDirection.Input,
			};
		}

        public static SqlParameter ToSqlInParam(string name, DateTime value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, DateTime? value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value ?? (object)DBNull.Value,
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, bool value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, string value, bool unicode=false)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                SqlDbType = unicode ? SqlDbType.NVarChar : SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, byte[] value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                Size = value.Length,
                SqlDbType = SqlDbType.VarBinary,
                Direction = ParameterDirection.Input,
            };
        }

        public static SqlParameter ToSqlInParam(string name, DataTable value, string typeName)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value,
                TypeName = typeName,
                SqlDbType = SqlDbType.Structured,
            };
        }

        public static SqlParameter ToSqlOutParam(string name, SqlDbType type)
        {
            return new SqlParameter
            {
                ParameterName = name,
                SqlDbType = type,
                Direction = ParameterDirection.Output,

                // used by types like varchar and nvarchar
                // note: truncation might occur if stored procedure sets value larger than the size defined below 
                Size = 512,
            };    
        }

        public static SqlParameter ExecuteStoredProcedure(
            string dbConnectionString,
            string storedProcName,
            params SqlParameter[] parameters)
        {
            // all stored procedures are designed to return an error code by default
            var returnCode = ToSqlOutParam("returnCode", SqlDbType.Int);

            // execute stored procedure
            using (var conn = new SqlConnection(dbConnectionString))
            {
                using (var cmd = new SqlCommand(storedProcName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    cmd.Parameters.Add(returnCode);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            return returnCode;
        }

        public static IEnumerable<T> ExecuteStoredProcedure<T>(
            string dbConnectionString,
            string storedProcName,
            Func<SqlDataReader, T> func,
            params SqlParameter[] parameters)
        {
            // reponse object
            var response = new List<T>();

            // execute stored procedure
            using (var conn = new SqlConnection(dbConnectionString))
            {
                using (var cmd = new SqlCommand(storedProcName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response.Add(func(reader));
                        }
                    }
                }
            }

            return response;
        }

        public static IEnumerable<T> ExecuteStoredProcedures<T>(
            string dbConnectionString,
            IEnumerable<string> storedProcNames,
            Func<SqlDataReader, T> func,
            params SqlParameter[] parameters)
        {
            // reponse object
            var response = new List<T>();

            // execute stored procedures
            // NOTE: all stored procedures in "storedProcesNames" must return the same type and must be convertible by "func"
            using (var conn = new SqlConnection(dbConnectionString))
            {
                conn.Open();
                foreach (var storedProcName in storedProcNames)
                {
                    using (var cmd = new SqlCommand(storedProcName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.Add(parameter);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.Add(func(reader));
                            }
                        }

                        // parameters must be cleared before they can use used for another SqlCommand
                        cmd.Parameters.Clear();
                    } 
                }
            }

            return response;
        }


    }
}
