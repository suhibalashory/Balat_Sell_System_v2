using DataLeayrs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BissnussLayer
{
	public class clsMakas
	{

		enum Mode { Add, Update }
		Mode _Mode = Mode.Add;


		public int MakasID { get; set; }
		public string Makas { get; set; }

		public clsMakas()
		{
			this.MakasID = 0;
			this.Makas = null;

			_Mode = Mode.Add;
		}

		private clsMakas(int MakasID, string Makas)
		{
			this.MakasID = MakasID;
			this.Makas = Makas;

			_Mode = Mode.Update;
		}

		public clsMakas Find(int MakasID)
		{
			string Makas = string.Empty;

			if (MakasData.GetMakas(MakasID,ref Makas))
				return new clsMakas(MakasID, Makas);
			else
				return null;
		}

		private bool _AddNew()
		{
			this.MakasID = MakasData.AddNewMakas(this.Makas);
			return (this.MakasID != 0);
		}

		private bool _Update()
		{
			return MakasData.UpdateMakas(this.MakasID,this.Makas);
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
			return MakasData.DeleteMakas(this.MakasID);
		}

		public static DataTable GetAll()
		{
			return MakasData.GetAllMakas();
		}

		public static string GetMakas(int MakasID)
		{
			return MakasData.GetMakasByID(MakasID);
		}

	}
}
