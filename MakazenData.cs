using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DataLeayrs
{
	public class MakazenData
	{
		public static bool GetInfoMakzen(int ID, ref string Name,ref string Number)
		{
			bool Found = false;
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"Select * from Makazen where MakzanID = @ID";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ID", ID);
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						try
						{
							if (reader.Read())
							{
								Name = (string)reader["Makzan"];

								if (reader["Number"] != System.DBNull.Value)
									Number = (string)reader["Number"];
								else
									Number = string.Empty;

								Found = true;
							}
						}
						catch
						{
							// EventLog.
							Found = false;

						}
					}

				}
			}
			return Found;
		}

		public static bool GetInfoMakzenByName(ref int ID,string Name,ref string Number)
		{
			bool Found = false;
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"Select * from Makazen where Makzan = @Name";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@Name", Name);

					try
					{
						connection.Open();

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								ID = (int)reader["MakzanID"];

								if(reader["Number"] != System.DBNull.Value)
									Number = (string)reader["Number"];
								else
									Number = string.Empty;

								Found = true;
							}
						}

					}
					catch
					{
						Found = false;
					}

				}
			}
			return Found;
		}


		public static DataTable GetAllMakazen()
		{
			DataTable dt = new DataTable();
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select Makzan from Makazen";
				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					
					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader != null)
								dt.Load(reader);
						}
					}
					catch 
					{
					}
				}
			}
			return dt;
		}

		public static int AddMakzan(string Makzan,string Number)
		{
			int Adding = -1;
			object done = null;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"INSERT INTO [dbo].[Makazen]
										     ([Makzan],[Number] ) VALUES
											  (@Makzan,@Number );
												SELECT SCOPE_IDENTITY();";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Makzan", Makzan);
					command.Parameters.AddWithValue("@Number",Number);
					
					try
					{
						connection.Open();
						done = command.ExecuteScalar();
						if(int.TryParse(done.ToString(), out int result))
							 Adding = result;

					}
					catch (Exception ex)
					{
						Adding = -1;
					}

				}
			}
			return Adding;
		}

		public static bool updateMakzan(int ID, string Makzan,string Number)
		{
			bool Updateing = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"UPDATE [dbo].[Makazen]
											SET [Makzan] = @Makzan,
												[Number] = @Number
											WHERE  MakzanID = @ID";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ID", ID);
					command.Parameters.AddWithValue("@Makzan", Makzan);
					command.Parameters.AddWithValue("@Number", Number);


					try
					{
						connection.Open(); command.ExecuteNonQuery(); Updateing = true;
					}
					catch (Exception ex)
					{ 
						Updateing = false;
					}
				}
			}
				return Updateing;
		}

		public static bool DeleteMakzan(int ID)
		{
			bool Deleteing = false;
			object result = null;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"DELETE FROM [dbo].[Makazen]
										WHERE MakzanID = @ID;";
				using(SqlCommand command = new SqlCommand(query,connection))

				{
					command.Parameters.AddWithValue("@ID" ,ID);
					try
					{
						connection.Open();
						result = command.ExecuteScalar();
						if (int.TryParse(result.ToString(), out int R))
							Deleteing = (R > 0);

					}
					catch (Exception ex)
					{
						Deleteing = false;
					}

				}

			}
			return Deleteing;
		}

		public static string GetMakzanNameByID(int ID)
		{
			string Name = string.Empty;
			object result = null;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"select Makzan from Makazen where MakzanID = @ID;";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ID", ID);
					try
					{
						connection.Open();
						result = command.ExecuteScalar();
						if (result != null)
							Name = result.ToString();

					}
					catch (Exception ex)
					{
						Name = string.Empty;
					}

				}

			}
			return Name;
		}

		public static DataTable GetAllMakazenWhitInfo()
		{
			DataTable dt = new DataTable();
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from Makazen";
				using (SqlCommand command = new SqlCommand(Query, connection))
				{

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader != null)
								dt.Load(reader);
						}
					}
					catch
					{
					}
				}
			}
			return dt;
		}



	}

}
