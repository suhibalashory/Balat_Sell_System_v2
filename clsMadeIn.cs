using System;
using System.Collections.Generic;
using System.Data;
using DataLeayrs;

namespace BissnussLayer
{
	public class clsMadeIn
	{
		enum Mode { Add, Update }
		Mode _Mode = Mode.Add;


		public int MadeInID { get; set; }
		public string Country { get; set; }

		public clsMadeIn()
		{
			this.MadeInID = 0;
			this.Country = null;

			_Mode = Mode.Add;
		}

		private clsMadeIn(int madeInID, string country)
		{
			this.MadeInID = madeInID;
			this.Country = country;

			_Mode = Mode.Update;
		}

		public static clsMadeIn Find(int MadeInID)
		{
			string Country = string.Empty;

			if (MadeInData.GetMadeInInfo(MadeInID, ref Country))
				return new clsMadeIn(MadeInID, Country);
			else
				return null;
		}

		public static DataTable GetAll()
		{
			return MadeInData.GetAllMadeIn();
		}

		public static string GetCountry(int MadeInID)
		{
			return MadeInData.GetCountryByID(MadeInID);
		}

		private bool _AddNew()
		{
			this.MadeInID = MadeInData.AddNewMadeIn(this.Country);
			return (this.MadeInID != 0);
		}

		private bool _Update()
		{
			return MadeInData.UpdateMadeIn(this.MadeInID, this.Country);
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

		public static bool DeleteMadIn(int MadeInID)
		{
			return MadeInData.DeleteMadeIn(MadeInID);
		}

		public bool Delete()
		{
			return DeleteMadIn(this.MadeInID);
		}

	}
	 
}
