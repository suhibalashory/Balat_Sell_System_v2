using System;
using System.Data;
using System.Data.SqlClient;


namespace DataLeayrs
{
	 public class FauaterAlMakazenData 
	 {

		public static DataTable GetAll()
		{
			DataTable dt = new DataTable();
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"select FatoraID as ID,
(select Makzan from Makazen where Makazen.MakzanID = FauaterAlMakazen.MakzenID) as Makzan ,
(select Balats.Code from Balats where Balats.BalataID = FauaterAlMakazen.BalataID ) as Code ,
Box,TotalSalary, case IsLocked

when 1 then 'خالص'
when 0 then 'غير خالص'
end

,Date,
(Select Mabiat.ClientName  from Mabiat where Mabiat.MabiatID = FauaterAlMakazen.MabiatID),
(Select Mabiat.ClientPhone  from Mabiat where Mabiat.MabiatID = FauaterAlMakazen.MabiatID )

from FauaterAlMakazen";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					try 
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								dt.Load(reader);
						}
					}
					catch (Exception ex)
					{ }
					
				}
			}
			return dt;
		}

		public static DataTable GetFauaterBetweenDate(DateTime From,DateTime To)
		{
			DataTable dt = new DataTable();
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"select FatoraID as ID,
(select Makzan from Makazen where Makazen.MakzanID = FauaterAlMakazen.MakzenID) as Makzan ,
(select Balats.Code from Balats where Balats.BalataID = FauaterAlMakazen.BalataID ) as Code ,
Box,TotalSalary, case IsLocked

when 1 then 'خالص'
when 0 then 'غير خالص'
end

,Date,
(Select Mabiat.ClientName  from Mabiat where Mabiat.MabiatID = FauaterAlMakazen.MabiatID),
(Select Mabiat.ClientPhone  from Mabiat where Mabiat.MabiatID = FauaterAlMakazen.MabiatID )

from FauaterAlMakazen where Date Between 
 @From  and  @To";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@From",From);
					command.Parameters.AddWithValue("@To", To);
					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								dt.Load(reader);
						}
					} catch (SqlException ex) 
					{ 

					}
				}
			}
			return dt;
		}

		public static DataTable GetFauater_AlMakzan(int MakzanID)
		{
			DataTable dataTable = new DataTable();
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"select * from FauaterAlMakazen where MakzanID = @MakzanID";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@MakzanID", MakzanID);
					connection.Open();
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.HasRows)
							dataTable.Load(reader);
					}
				}
			}
			return dataTable;
		}

		public static bool Get_FAM_info(int FatoraID, ref int MakzanID,ref int MabiatID, ref int BalataID, ref decimal TotalSalary,ref int Box, ref bool IsLocked, ref DateTime Date)
		{
			bool Found = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select * from FauaterAlMakazen Where FatoraID = @FatoraID";
				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@FatoraID", FatoraID);

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								MakzanID = (int)reader["MakzanID"];
								MabiatID = (int)reader["MabiatID"];
								BalataID = (int)reader["BalataID"];
								TotalSalary = (decimal)reader["TotalSalary"];
								Box = (reader["Box"] != System.DBNull.Value) ? (int)reader["Box"] : 0;
								IsLocked = ((byte)reader["IsLocked"] == 1);
								Date = (DateTime)reader["Date"];

								Found = true;
							}
						}
					}
					catch (Exception ex)
					{ Found = false; }
				}
			}

			return Found;
		}

		public static int AddNewFatora(int MakzanID,int MabiatID, int BalataID, decimal TotalSalary,int Box, bool IsLocked, DateTime Date)
		{
			int FatoraID = 0;
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Qurey = @"
                                  INSERT INTO [dbo].[FauaterAlMakazen]
           ([MabiatID]
           ,[MakzenID]
           ,[BalataID]
           ,[TotalSalary]
           ,[Box]
           ,[IsLocked]
           ,[Date])
VALUES
                            (      @MabiatID ,
                                  @MakzanID ,
                                  @BalataID ,
                                  @TotalSalary ,
                                  @Box ,
                                  @IsLocked,
                                  @Date ) select SCOPE_IDENTITY();
                                  ";

				using(SqlCommand command = new SqlCommand(Qurey, connection))
				{
					command.Parameters.AddWithValue("@MakzanID", MakzanID);
					command.Parameters.AddWithValue("@BalataID", BalataID);
					command.Parameters.AddWithValue("@MabiatID", MabiatID);
					command.Parameters.AddWithValue("@TotalSalary", TotalSalary);

					if(Box != 0)
						command.Parameters.AddWithValue("@Box", Box);
					else
						command.Parameters.AddWithValue("@Box", System.DBNull.Value);

					if (IsLocked)
						command.Parameters.AddWithValue("@IsLocked", 1);
					else
						command.Parameters.AddWithValue("@IsLocked", 0);

					command.Parameters.AddWithValue("@Date", Date);

					try
					{
						connection.Open();
						object Adding = command.ExecuteScalar();
						if (int.TryParse(Adding.ToString(), out int result))
							FatoraID = result;
						
					}
					catch (SqlException ex) 
					{ FatoraID = 0; }
				}
			}
			return FatoraID;
		}

		public static bool UpdateFatora(int FatoraID,int MakzanID, int MabiatID, int BalataID, decimal TotalSalary, int Box, bool IsLocked, DateTime Date)
		{
			bool updateing = false;

			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Qurey = @"exec sp_UpdateFatora
                                    @FatoraID ,
                                    @MabiatID  ,
                                    @MakzanID  , 
                                    @BalataID  , 
                                    @TotalSalary ,
                                    @Box ,
                                    @IsLocked, 
                                    @Date  ;";

				using (SqlCommand command = new SqlCommand(Qurey, connection))
				{
					command.Parameters.AddWithValue("@FatoraID", FatoraID);
					command.Parameters.AddWithValue("@MakzanID", MakzanID);
					command.Parameters.AddWithValue("@BalataID", BalataID);
					command.Parameters.AddWithValue("@MabiatID", MabiatID);
					command.Parameters.AddWithValue("@TotalSalary", TotalSalary);

					if (Box != 0)
						command.Parameters.AddWithValue("@Box", Box);
					else
						command.Parameters.AddWithValue("@Box", System.DBNull.Value);


					if(IsLocked)
						command.Parameters.AddWithValue("@IsLocked", 1 );
					else
						command.Parameters.AddWithValue("@IsLocked", 0);

					command.Parameters.AddWithValue("@Date", Date);

					try
					{
						connection.Open();
						object Adding = command.ExecuteNonQuery();
						if (int.TryParse(Adding.ToString(), out int result))
							updateing = (result > 0);
							

					}
					catch (SqlException ex)
					{ updateing = false; }
				}
			}

			return updateing;
		}

		public static bool DeleteFatora(int  FatoraID)
		{
			bool Deleteing = false;

			using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"DELETE FROM [dbo].[FauaterAlMakazen]
                          WHERE FatoraID = @FatoraID";

				using (SqlCommand command = new SqlCommand(query, conn))
				{
					command.Parameters.AddWithValue("@FatoraID", FatoraID);
					try
					{
						conn.Open();
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

		public static int GetTotalSalaryBy_MabiatID(int MabiatID)
		{
			int TotalSalary = 0;
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select TotalSalary = COUNT(FauaterAlMakazen.TotalSalary)  from FauaterAlMakazen Were MabiatID = @MabiatID ";
				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@MabiatID", MabiatID);

					try
					{
						connection.Open();
						object Total = command.ExecuteScalar();
						if (int.TryParse(Total.ToString(), out int result))
							TotalSalary = result;
					}
					catch (SqlException ex) { TotalSalary = 0; }

				}

			}
			return TotalSalary;
		}




	 }
}