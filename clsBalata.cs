using DataLeayrs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BissnussLayer
{
	public class clsBalata
	{
		enum _Mode { Add = 1, update = 2 }
		_Mode _mode;

		public int BalatID { get; set; }
		public int TypeID { get; set; }
		public string Type
		{
			get
			{
				return clsBalatType.GetType(this.TypeID);
			}
		}
		public int MakazenID { get; set; }
		public string Makzan {
			get
			{
				return clsMakzen.GetMakzan(this.MakazenID);
			}
		}
		public string Code { get; set; }
		public int MadeInID { get; set; }
		public string MadeIn
		{ 
			get
			{
				return clsMadeIn.GetCountry(this.MadeInID);
			}
		}
		public decimal Salary { get; set; }
		public float MiterInBox { get; set; }  // Make it
		public int MakasID { get; set; }
		public string Makas
		{
			get
			{
				return clsMakas.GetMakas(this.MakasID);
			}
		}
		public string Picture_Path { get; set; }

		public clsBalata()
		{
			this.BalatID = 0;
			this.MakazenID = 0;
			this.MakasID = 0;
			this.TypeID = 0;
			this.Code = string.Empty;
			this.MiterInBox = 0;
			this.Salary = 0;
			this.MakasID = 0;
			this.Picture_Path = string.Empty;

			_mode = _Mode.Add;
		}

		private clsBalata(int BalataID, int MakazenID,int BalataTypeID,int MadeInID,string Code,float MiterInBox, decimal Salary, int MakasID,string Picture)
		{
			this.BalatID = BalataID;
			this.MakazenID= MakazenID;
			this.TypeID = BalataTypeID;
			this.MadeInID = MadeInID;
			this.Code = Code;
			this.MiterInBox = MiterInBox;
			this.Salary = Salary;
			this.Picture_Path = Picture;


			_mode = _Mode.update;
		}

		public static clsBalata Find(int ID)
		{
			int MakzanID = 0, MakasID = 0, TypeID = 0, MadeInID = 0;
			float MiterInbox = 0;
			decimal Salary = 0;
			string Code = string.Empty,Picture = string.Empty;

			if (BalatData.GetBalataInfo(ID,ref MakzanID,ref TypeID,ref MadeInID,ref Code,ref MiterInbox,ref Salary,ref MakasID,ref Picture))
				return new clsBalata(ID, MakzanID, TypeID, MadeInID, Code,MiterInbox, Salary, MakasID,Picture);
			else
				return null;
		}

		public static clsBalata FindByCode_and_MakzenID(string Code,int MakzanID)
		{

			int BalataID = 0,  MakasID = 0, TypeID = 0, MadeInID = 0;
			float MiterInBox = 0;
			decimal Salary = 0;
			string Picture = string.Empty;

			if (BalatData.GetBalataInfoByCode
				(ref BalataID, MakzanID,ref TypeID,ref MadeInID,Code,ref MiterInBox,ref Salary,ref MakasID,ref Picture))

				return new clsBalata(BalataID, MakzanID, TypeID, MadeInID, Code,MiterInBox, Salary, MakasID, Picture);
			else
				return null;
		}

		private bool _AddNewBalat()
		{
			this.BalatID = BalatData.AddNewBalata(this.MakazenID,this.TypeID,this.MadeInID,this.Code,this.MiterInBox, this.Salary, this.MakasID,this.Picture_Path);
			return (this.BalatID != -1);
		}

		private bool _UpdateBalat()
		{
			return BalatData.UpdateBalata(this.BalatID,this.MakazenID,this.TypeID,this.MadeInID,this.Code,this.MiterInBox,this.Salary,this.MakasID,this.Picture_Path);
		}

		public bool Save()
		{
			switch (_mode)
			{
				case _Mode.Add:
					if (_AddNewBalat())
					{
						_mode = _Mode.update;
						return true;
					}
					else
						return false;


				case _Mode.update:
					return _UpdateBalat();

			}
			return false;
		}

		public static DataTable GetAll()
		{
			return BalatData.GetAllBalat();
		}

		public static DataTable GetAllBalatsInMakzan(int MakzanID)
		{
			return BalatData.GetAllBalatInMakzan(MakzanID);
		}

		public static bool DeleteByID(int SenfID)
		{
			return BalatData.DeleteRecord(SenfID);
		}

		public static bool IsBalatExistByCode_and_MakzenID(string Code,int MakzanID)
		{
			return BalatData.IsBalatExistByCode(0);
		}


	}
}