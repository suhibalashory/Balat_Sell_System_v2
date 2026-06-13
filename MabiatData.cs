using System;
using System.Data;
using System.Data.SqlClient;


namespace DataLeayrs
{
	 public class MabiatData
	 {
		public static DataTable GetAll()
		{
			DataTable table = new DataTable();
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"select Mabiat.ClientName,Mabiat.ClientPhone,
	   Mabiat.TotalSalary,
	   albaqy ,Date

	   from Mabiat;";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								table.Load(reader);
						}
					}
					catch (SqlException ex)
					{ }
				}
			}
			return table;
		}

		public static DataTable GetAllBetweenDate(DateTime from,DateTime to)
		{
			DataTable table = new DataTable();
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"select Mabiat.ClientName,Mabiat.ClientPhone,
	   Mabiat.TotalSalary,
	   case Mabiat.IsLocked 
	   when 1 then 'خالص' 
	   when 0 then 'غير خالص' 
	   end as الحالة ,
	   albaqy ,Date

	   from Mabiat Where Date Between @From and @To";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@From", from);
					command.Parameters.AddWithValue("@To", to);
					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								table.Load(reader);
						}
					}
					catch (SqlException ex)
					{ }
				}
			}
			return table;
		}

		public static DataTable GetMabiatInfo(int MabiatID)
		{
			DataTable table = new DataTable();
			//  exec sp_GetFauaterByMabiatID 2
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"exec sp_GetFauaterByMabiatID  @MabiatID";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@MabiatID", MabiatID);
					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								table.Load(reader);
						}
					}
					catch (SqlException ex)
					{ 

					}
				}
			}

			return table ;
		}

		public static bool GetMabiat_Info(int MabiateID,ref string C_Name,ref string C_Phone,ref decimal TotalSalary,ref decimal AlBaqy,ref DateTime date)
		{
			bool Found = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from Mabiat where F_MabiatID = @MabiatID;";

				using(SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@MabiatID", MabiateID);
					try
					{
						connection.Open();
						using(SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								C_Name = (string)reader["ClientName"];
								C_Phone = (string)reader["ClientPhone"];
								TotalSalary = (decimal)reader["TotalSalary"];
								AlBaqy = (decimal)reader["AlBaqy"];
								date = (DateTime)reader["Date"];

								Found = true;
							}
						}
					}
					catch (SqlException ex)
					{
						Found = false;
					}
				}
			}

			return Found;
		}

	
		public static int AddNewMabiat(string C_Name,string C_Phone,decimal TotalSalary,decimal AlBaqy, DateTime date)
		{
			int Add = 0;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"INSERT INTO [dbo].[Mabiat]
           ([ClientName]
           ,[ClientPhone]
           ,[TotalSalary]
           ,[AlBaqy]
           ,[Date])
     VALUES(
									@ClientName,
									@ClientPhone,
									@TotalSalary,
									@AlBaqy,
								    @Date )  select SCOPE_IDENTITY(); ";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ClientName",C_Name);
					command.Parameters.AddWithValue("@ClientPhone", C_Phone);
					command.Parameters.AddWithValue("@TotalSalary", TotalSalary);
					command.Parameters.AddWithValue("@AlBaqy", AlBaqy);
					command.Parameters.AddWithValue("@Date", date);
					try
					{
						connection.Open();
						object Adding = command.ExecuteScalar();
						if(int.TryParse(Adding.ToString(), out int result))
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

		public static bool UpdateMabiat(int MabiatID, string C_Name, string C_Phone, decimal TotalSalary,decimal AlBaqy, DateTime date)
		{
			bool Updateing = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"exec sp_UpdateMabiatMabiat  
									@ClientName,
									@ClientPhone,
									@TotalSalary,
                                    @AlBaqy,
								    @Date ;";

				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ClientName", C_Name);
					command.Parameters.AddWithValue("@ClientPhone", C_Phone);
					command.Parameters.AddWithValue("@TotalSalary", TotalSalary);
					command.Parameters.AddWithValue("@AlBaqy", AlBaqy);
					command.Parameters.AddWithValue("@Date", date);
					try
					{
						connection.Open();
						object Update = command.ExecuteScalar();
						if (int.TryParse(Update.ToString(), out int result))
							Updateing = result > 0;
					}
					catch (SqlException ex)
					{
						Updateing = false;
					}
				}
			}
			return Updateing;
		}

		public static bool DeleteMabiat(int MabiatID)
		{
			// sp_DeleteAllFauaterByMabiatID
			// sp_DeleteMabiatID  

			bool Deleteing = false;
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"exec sp_DeleteMabiatID @MabiatID";

				using (SqlCommand command = new SqlCommand(Query,connection))
				{
					command.Parameters.AddWithValue("@MabiatID", MabiatID);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						Deleteing = true;
					}
					catch (SqlException ex)
					{
						Deleteing = false;
					}

				}
			}

			return Deleteing;
		}





   	 }
}
