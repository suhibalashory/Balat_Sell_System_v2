using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLeayrs
{
	public class BalatTypeData
	{

		public static bool GetBalataTypeInfo(int BalataTypeID,ref string Type)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from BalataType where BalataTypeID = @ID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ID", BalataTypeID);

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								Type = reader.GetString(1);
								result = true;
							}
							else
								result = false;

						}

					}
					catch (SqlException ex)
					{
						result = false;
					}
				}
			}

			return result;
		}

		public static DataTable GetAllBalataType()
		{
			DataTable DT = new DataTable();

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from BalataType";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								DT.Load(reader);
						}
					}
					catch (SqlException ex)
					{

					}
				}
			}

			return DT;
		}

		public static string GetBalataType(int BalataTypeID)
		{
			string result = string.Empty;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select Type from BalataType where BalataTypeID = @ID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ID", BalataTypeID);

					try
					{
						connection.Open();
						object handel = command.ExecuteScalar();
						if (handel != null)
							result = handel.ToString();
					}
					catch (SqlException ex)
					{
						result = string.Empty;
					}
				}
			}

			return result;
		}

		public static int AddNewType(string Type)
		{
			int Add = -1;
			object Hand = null;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"insert into dbo.BalataType (Type) values (@Type)
									SELECT SCOPE_IDENTITY()";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@Type", Type);

					try
					{
						connection.Open();
						object handel = command.ExecuteScalar();
						if (int.TryParse(handel.ToString(), out int result))
							Add = result;
					}
					catch (SqlException ex)
					{
						Add = 0;
					}
				}
			}

			return Add;
		}

		public static bool UpdateType(int BalataTypeID,string Type)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"update BalataType set 
									[Type] = @Type
										where BalataTypeID = @ID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@Country", Type);
					command.Parameters.AddWithValue("@ID", BalataTypeID);

					try
					{
						connection.Open();
						object handel = command.ExecuteNonQuery();
						if (handel != null)
							result = true;

					}
					catch (SqlException ex)
					{
						result = false;
					}
				}
			}

			return result;
		}

		public static bool DeleteType(int BalataTypeID)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"delete from BalataType where BalataTypeID = @ID;";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ID", BalataTypeID);

					try
					{
						connection.Open();
						object handel = command.ExecuteNonQuery();
						if (handel != null)
							result = true;
					}
					catch (SqlException ex)
					{
						result = false;
					}
				}
			}

			return result;
		}


	}
}
