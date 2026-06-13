using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLeayrs
{
    public class UserData
    {
        public static bool GetUserInfo(int ID,ref string Name,ref string Password,ref bool IsAdmin)
        {
            bool Find = false;

            using(SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
            {
                string Query = "select * from Users where ID = @ID";
                using(SqlCommand command = new SqlCommand(Query,conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    try
                    {
                        conn.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                Name = (string)reader["Name"];
                                Password = (string)reader["Password"];
                              
                                if ((int)reader["IsAdmin"] == 1)
                                    IsAdmin = true;
                                else
                                    IsAdmin = false;

							}
                        }
                    }
                    catch
                    {
                        Find = false;
                    }
                    
                }
            }
            return Find;
        }

		public static bool GetUserInfo_By_Name_password(ref int ID,string Name,string Password, ref bool IsAdmin)
		{
			bool Find = false;

			using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = "select * from Users where UserName = @Name and PassWord = @Password";
				using (SqlCommand command = new SqlCommand(Query, conn))
				{
					command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Password",Password);

					try
					{
						conn.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								ID = (int)reader["UserID"];
								Password = (string)reader["PassWord"];

                                IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));

                                Find = true;

							}
						}
					}
					catch
					{
						Find = false;
					}

				}
			}
			return Find;
		}

        public static List<string> GetAllUsersName()
        {
           List<string> list = new List<string>();

            using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
            {
                string query = "select UserName from Users";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                list.Add(reader["UserName"].ToString());
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }

            return list;
        }

		public static DataTable GetAllUsersInfo()
		{
			DataTable DT = new DataTable();

			using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = "select * from Users where IsAdmin = 0";

				using (SqlCommand command = new SqlCommand(query, conn))
				{
					try
					{
						conn.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								DT.Load(reader);
						}
					}
					catch
					{

					}
				}
			}

			return DT;
		}

		public static bool Check_UserName_And_Password(string Name,string Password)
        {
            bool Find = false;
            object F = null;
            using(SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
            {
                string query = "select 1 from Users where Name = @Name and Password = @Password";
                using (SqlCommand comand = new SqlCommand(query, conn))
                {
                    comand.Parameters.AddWithValue("@Name", Name);
                    comand.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        conn.Open();
                        F = comand.ExecuteScalar();

                        if (F != null)
                        {
                            if (int.TryParse(F.ToString(), out int result))
                                Find = result == 1;
                        }
                        else
                        {
                            Find = false;
                        }

                    }catch
                    {
                        Find = false;
                    }

                }
            }

            return Find;
        }

        public static int _AddNewUser(string Name,string Password)
        {
            int ID = -1;

            using(SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
            {
                string Qurey = @"INSERT INTO [dbo].[Users]
                                            ([Name]
                                            ,[Password]
                                            ,[IsAdmin])
                                      VALUES
                                            (@Name
                                            ,@Password
                                            ,0)"; // set 0 to all User

                using(SqlCommand command = new SqlCommand(Qurey,conn))
                {
                    command.Parameters.AddWithValue("@Name",Name);
					command.Parameters.AddWithValue("@Password",Password);
                    
                    try
                    {
                        conn.Open();
                        object obj = command.ExecuteScalar();
                        if (int.TryParse(obj.ToString(), out int result))
                            ID = result;


                    } 
                    catch
                    {
                        ID = -1;
                    }

				}
            }

            return ID;
        }

        public static bool _UpdateUserInfo(int ID, string Name, string Password)
        {
            bool Update = false;

			using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
			{
				string Qurey = @"UPDATE [dbo].[Users]
                                       SET [Name] = @Name
                                          ,[Password] = @Password
                                          ,[IsAdmin] = 0
                                     WHERE ID = @ID"; // set 0 to all User

				using (SqlCommand command = new SqlCommand(Qurey, conn))
				{
                    command.Parameters.AddWithValue("@ID", ID);
					command.Parameters.AddWithValue("@Name", Name);
					command.Parameters.AddWithValue("@Password", Password);

					try
					{
						conn.Open();
                        object obj = command.ExecuteNonQuery();
                        if (int.TryParse(obj.ToString(), out int result))
                            Update = result > 0;


					}
					catch
					{
						Update = false;
					}

				}
			}

			return Update;
		}

        public static bool DeleteUser(int ID)
        {
            bool Delete = false;

			using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
			{
				string Qurey = @"DELETE FROM [dbo].[Users] WHERE  ID = @ID"; 
				using (SqlCommand command = new SqlCommand(Qurey, conn))
				{
					command.Parameters.AddWithValue("@ID", ID);


					try
					{
						conn.Open();
						object obj = command.ExecuteScalar();
                        if (int.TryParse(obj.ToString(), out int result))
                            Delete = result > 0;


					}
					catch
					{
                        Delete = false;
					}

				}
			}

            return Delete;
		}


    }
}
