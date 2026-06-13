using System;
using System.Collections.Generic;
using System.Data;
using DataLeayrs;

namespace BissnussLayer
{
	public class clsBalatType
	{

		enum Mode { Add, Update }
		Mode _Mode = Mode.Add;


		public int BalataTypeID { get; set; }
		public string Type { get; set; }

		public clsBalatType()
		{
			this.BalataTypeID = 0;
			this.Type = string.Empty;

			_Mode = Mode.Add;
		}

		private clsBalatType(int BalataTypeID, string Type)
		{
			this.BalataTypeID = BalataTypeID;
			this.Type = Type;

			_Mode = Mode.Update;
		}
		
		public static clsBalatType Find(int BalatTypeID)
		{
			string Type = string.Empty;

			if (BalatTypeData.GetBalataTypeInfo(BalatTypeID,ref Type))

				return new clsBalatType(BalatTypeID,Type);
			else
				return null;
		}

		public static DataTable GetAll()
		{
			return BalatTypeData.GetAllBalataType();
		}

		public static string GetType(int TypeID)
		{
			return BalatTypeData.GetBalataType(TypeID);
		}

		private bool _AddNew()
		{
			this.BalataTypeID = BalatTypeData.AddNewType(this.Type);
			return (this.BalataTypeID != 0);
		}

		private bool _Update()
		{
			return BalatTypeData.UpdateType(BalataTypeID, this.Type);
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

		public static bool DeleteType(int BalataTypeID)
		{
			return BalatTypeData.DeleteType(BalataTypeID);
		}
		public bool Delete()
		{
			return DeleteType(this.BalataTypeID);
		}



	}
}
