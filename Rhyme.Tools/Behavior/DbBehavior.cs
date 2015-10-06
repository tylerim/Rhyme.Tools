using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Server.Lib.Common;

namespace Rhyme.Tools.Behavior
{
	public static class DbBehavior
	{
		public delegate void PrintLogHandler(params string[] logs);
		public static event PrintLogHandler PrintLog = delegate { };

		public static string DbConnectionString { get; set; }

		//-------------------------------------------------------------------------
		// Private methods
		//-------------------------------------------------------------------------
		private static void ThrowIfNotValid(params SqlParameter[] parameters)
		{
			foreach (var parameter in parameters)
			{
				if (parameter.Value.Equals(DBNull.Value))
					throw new Exception(String.Format("Output parameter {0} is null", parameter.ParameterName));
			}
		}

		private static uint ExecuteStoredProcedure(string storedProcName, params SqlParameter[] parameters)
		{
			var returnParam = SqlHelper.ExecuteStoredProcedure(
				DbConnectionString,
				storedProcName,
				parameters);

			// stored procedure did not return an error code
			if (returnParam.Value.Equals(DBNull.Value))
			{
				throw new Exception("Stored procedure returned null");
			}

			// stored procedures must return one of the defined values ResultCode.cs (hence, >= 0)
			var returnVal = (int)returnParam.Value;
			if (returnVal < 0)
			{
				throw new Exception("Stored procedure returned result code < 0");
			}

			return (uint)returnVal;
		}

		private static List<T> ExecuteStoredProcedure<T>(string storedProcName, Func<SqlDataReader, T> func, params SqlParameter[] parameters)
		{
			return SqlHelper.ExecuteStoredProcedure(
				DbConnectionString,
				storedProcName,
				func,
				parameters).ToList();
		}

		private static List<T> ExecuteStoredProcedures<T>(IEnumerable<string> storedProcNames, Func<SqlDataReader, T> func, params SqlParameter[] parameters)
		{
			// NOTE: all stored procedures in "storedProcesNames" must return the same type and must be convertible by "func"
			return SqlHelper.ExecuteStoredProcedures(
				DbConnectionString,
				storedProcNames,
				func,
				parameters).ToList();
		}

		//-------------------------------------------------------------------------
		// Public methods
		//-------------------------------------------------------------------------
		public static uint CreateTourney(int tourneyTemplateId, int bufferTime)
		{
			try
			{
				// out params
				var tourneyId = SqlHelper.ToSqlOutParam("tourneyId", SqlDbType.Int);
				//var returnCode = SqlHelper.ToSqlOutParam("returnCode", SqlDbType.Int);
				
				// query DB
				// throws InternalException
				return ExecuteStoredProcedure(
					"dbo.p_CreateTourney",
					SqlHelper.ToSqlInParam("tourneyTemplateId", tourneyTemplateId),
					SqlHelper.ToSqlInParam("startTime", DateTime.UtcNow.AddSeconds(60 + bufferTime)),
					SqlHelper.ToSqlInParam("announceTime", DateTime.UtcNow.AddHours(-1)),
					SqlHelper.ToSqlInParam("registerTime", DateTime.UtcNow.AddHours(-1)),
					SqlHelper.ToSqlInParam("seatingTime", TimeSpan.FromSeconds(5.0)),
					tourneyId);
				//returnCode);
			}
			catch (Exception ex)
			{
				PrintLog(string.Format("Error, {0}", ex));

				return uint.Parse("-1");
			}
		}

		public static DataTable ExecuteSql(string sql)
		{
			try
			{
				return SqlHelperAdd.ExecuteSql(DbConnectionString, sql);
			}
			catch (Exception ex)
			{
				PrintLog(string.Format("Error, {0}", ex));

				return new DataTable();
			}
		}

		public static void ExecuteOnlySql(string sql)
		{
			try
			{
				SqlHelperAdd.ExecuteOnlySql(DbConnectionString, sql);
			}
			catch (Exception ex)
			{
				PrintLog(string.Format("Error, {0}", ex));
			}
		}
	}
}
