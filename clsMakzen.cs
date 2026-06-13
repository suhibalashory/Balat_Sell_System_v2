using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLeayrs;


namespace BissnussLayer
{
	public class clsMakzen
	{
		
		enum Mode { Add = 1, Update = 2 }
		Mode _Mode;

		public int MakazenID { get; set; }
		public string Name { get; set; }
		public string Number { get; set; }


		public clsMakzen()
		{
			this.MakazenID = -1;
			this.Name = string.Empty;
			this.Number = string.Empty;

			_Mode = Mode.Add;
		}

		private clsMakzen(int MakazenID, string Name)
		{
			this.MakazenID = MakazenID;
			this.Name = Name;

			_Mode = Mode.Update;
		}

		public static clsMakzen Find(int MakazenID)
		{
			string Name = string.Empty, Number = string.Empty;

			if (MakazenData.GetInfoMakzen(MakazenID, ref Name,ref Number))

				return new clsMakzen(MakazenID, Name);
			else

				return null;
		}

		public static clsMakzen Find(string Name)
		{
			int ID = -1;
			string Number = string.Empty;

			if (MakazenData.GetInfoMakzenByName(ref ID,Name,ref Number))
				return new clsMakzen( ID, Name);
			else
				return null;
		}

		private bool _AddMakzan()
		{
			this.MakazenID = MakazenData.AddMakzan(this.Name,this.Number);

			return (this.MakazenID != -1);
		}

		private bool _updateMakzan()
		{
			return MakazenData.updateMakzan(this.MakazenID, this.Name,this.Number);
		}

		public static bool DeleteMakzen(int MakzanID)
		{
			return MakazenData.DeleteMakzan(MakzanID);
		}

		public bool Delete()
		{
			return DeleteMakzen(this.MakazenID);
		}

		public bool Save()
		{
			switch (_Mode)
			{
				case Mode.Add:
					if (_AddMakzan())
					{
						_Mode = Mode.Update;
						return true;
					}
					break;

				case Mode.Update:
					
					return _updateMakzan();
			}
			return false;
		}

		public static DataTable GetAll()
		{
			return MakazenData.GetAllMakazen();
		}

		public static string GetMakzan(int ID)
		{
			return MakazenData.GetMakzanNameByID(ID);
		}

		public static DataTable GetMakazenTableWhitInfo()
		{
			return MakazenData.GetAllMakazenWhitInfo();
		}

	}

}

