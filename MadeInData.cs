using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLeayrs
{
	public class MadeInData
	{

		public static bool GetMadeInInfo(int MadeInID, ref string Country)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from MadeIn where MadeInID = @MadeInID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@MadeInID", MadeInID);

					try
					{
						connection.Open();
						using(SqlDataReader reader = command.ExecuteReader())
						{
							if(reader.Read())
							{
								Country = reader.GetString(1);
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

		public static DataTable GetAllMadeIn()
		{
			DataTable DT = new DataTable();

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from MadeIn";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if(reader.HasRows)
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

		public static string GetCountryByID(int MadeInID)
		{
			string result = string.Empty;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select Country from MadeIn where MadeInID = @MadeInID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@MadeInID", MadeInID);

					try
					{
						connection.Open();
						object handel = command.ExecuteScalar();
						if(handel != null)
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

		public static int AddNewMadeIn(string Country)
		{
			int Add = 0;
			object Hand = null;
			
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"insert into dbo.MadeIn (Country) values (@Country)
									SELECT SCOPE_IDENTITY()";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@Country", Country);

					try
					{
						connection.Open();
						object handel = command.ExecuteScalar();
						if(int.TryParse(handel.ToString(), out int result))
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

		public static bool UpdateMadeIn(int MadeInID, string Country)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"update MadeIn set 
									[Country] = @Country
										where MadeInID = @MadeInID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@Country", Country);
					command.Parameters.AddWithValue("@MadeInID", MadeInID);

					try
					{
						connection.Open();
						object handel = command.ExecuteNonQuery();
						if(handel != null)
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

		public static bool DeleteMadeIn(int MadeInID)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"delete from MadeIn where MadeInID = @MadeInID;";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@MadeInID", MadeInID);

					try
					{
						connection.Open();
						object handel = command.ExecuteNonQuery();
						if(handel != null)
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
