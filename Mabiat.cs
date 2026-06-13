using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLeayrs;

namespace BissnussLayer
{
	public class Mabiat
	{
		enum Mode { Add, Update }
		Mode _Mode = Mode.Add;

		public int     MabiatID { get; set; }
		public string  ClientName { get; set; }
		public string  ClientPhone { get; set; }
		public decimal  TotalSalary { get; set; }
		public decimal AlBaqy { get; set; }
		public bool IsLocked {  get; set; }
		public DateTime Date {  get; set; }
		public DataTable FauaterRows { get;set; }


		public Mabiat()
		{

			this.MabiatID = 0;
			this.ClientName = string.Empty;
			this.ClientPhone = string.Empty;
			this.TotalSalary = 0;
			this.AlBaqy = 0;
			this.Date = DateTime.MinValue;

			_Mode = Mode.Add;
		}

		private Mabiat(int MabiatID,string ClientName,string ClientPhone,decimal TotalSalary,decimal AlBaqy,DateTime Date)
		{

			this.MabiatID = MabiatID;
			this.ClientName = ClientName;
			this.ClientPhone = ClientPhone;
			this.TotalSalary = TotalSalary;
			this.AlBaqy = AlBaqy;
			this.Date = Date;
			this.FauaterRows = _GetFatoraRow();

			_Mode = Mode.Update;
		}

		public static DataTable GetAll()
		{
			return MabiatData.GetAll();
		}

		public static DataTable GetAllBetween(DateTime from,DateTime to)
		{
			return MabiatData.GetAllBetweenDate(from, to);
		}

		public static Mabiat Find(int MabiatID)
		{
			string C_Name= string.Empty, C_Phone = string.Empty;
			decimal TotalSalary = 0, Albaqy = 0;
			 DateTime dateTime = DateTime.MinValue;

			bool find = MabiatData.GetMabiat_Info(MabiatID, ref C_Name,
				ref C_Phone, ref TotalSalary, ref Albaqy, ref dateTime);
		
			if (find)
				return new Mabiat(MabiatID, C_Name, C_Phone, TotalSalary, Albaqy, dateTime);
			else
				return null;
		}

		private DataTable _GetFatoraRow()
		{
			return MabiatData.GetMabiatInfo(this.MabiatID);
		}

		private bool _AddNew()
		{
			this.MabiatID = MabiatData.AddNewMabiat(this.ClientName,this.ClientPhone,
				this.TotalSalary,this.AlBaqy,this.Date);

			return (this.MabiatID > 0);
		}

		private bool _Update()
		{
			return MabiatData.UpdateMabiat(this.MabiatID, this.ClientName,
				this.ClientPhone, this.TotalSalary,this.AlBaqy, this.Date);
		}

		public bool Save()
		{
			switch (_Mode)
			{
				case Mode.Add:
					if (_AddNew())
					{
						_Mode = Mode.Update;
						return true;
					}
					break;
				case Mode.Update:
					return _Update();
			}

			return false;
		}


		public bool Delete()
		{
			// this.MadeInID;
			// delete from Fauater Befor 

			return DeleteMabiate(this.MabiatID);
		}

		public static bool DeleteMabiate(int MabiatID)
		{
			// this.MadeInID;
			// delete from Fauater Befor 

			return MabiatData.DeleteMabiat(MabiatID);
		}
	}
}
