using System;
using System.Data;
using System.Data.SqlClient;
namespace DataLeayrs
{
	public class MakasData
	{
		public static bool GetMakas(int MakasID, ref string Makas)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from BalataType where MakasID = @ID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ID", MakasID);

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								Makas = reader.GetString(1);
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

		public static DataTable GetAllMakas()
		{
			DataTable DT = new DataTable();

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from Makas";

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

		public static string GetMakasByID(int MakasID)
		{
			string result = string.Empty;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select Makas from Makas where MakasID = @ID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ID", MakasID);

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

		public static int AddNewMakas(string Makas)
		{
			int Add = -1;
			object Hand = null;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"insert into dbo.Makas (Makas) values (@Makas)
									SELECT SCOPE_IDENTITY()";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@Makas", Makas);

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

		public static bool UpdateMakas(int MakasID, string Makas)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"update Makas set 
									[Makas] = @Makas
										where MakasID = @ID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@Makas", Makas);
					command.Parameters.AddWithValue("@ID", MakasID);

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

		public static bool DeleteMakas(int MakasID)
		{
			bool result = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"delete from Makas where MakasID = @ID;";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ID", MakasID);

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
