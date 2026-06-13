using System;
using System.Collections.Generic;
using System.Data;
using DataLeayrs;

namespace BissnussLayer
{
	public class FauaterAlMakazen
	{
		enum Mode { Add, Update }
		private Mode _Mode;

		public int FatoraID { get; set; }
		public int MabiatID { get; set; }
		public int MakzanID { get; set; }
		public int BalataID { get; set; }
		public decimal TotalSalary { get; set; }
		public int Box { get; set; }
		public bool IsLocked { get; set; } // 1 Miyn Locked
		public DateTime Date { get; set; }

		public FauaterAlMakazen()
		{
			this.FatoraID = 0;
			this.MabiatID = 0;
			this.MakzanID = 0;
			this.BalataID = 0;
			this.TotalSalary = 0;
			this.Box = 0;

			this.IsLocked = false;
			this.Date = DateTime.Now;

			_Mode = Mode.Add;
		}

		private FauaterAlMakazen(int FatoraID,int MabiatID, int MakzanID, int BalataID, decimal TotalSalary,int Box, bool IsLocked, DateTime Date)
		{
			this.FatoraID = FatoraID;
			this.MabiatID = MabiatID;
			this.MakzanID = MakzanID;
			this.BalataID = BalataID;
			this.TotalSalary = TotalSalary;
			this.IsLocked = IsLocked;
			this.Date = Date;

			_Mode = Mode.Update;
		}

		public static FauaterAlMakazen Find(int FatoraID)
		{
			int MakazenID = 0, BalataID = 0, MabiatID = 0, Box = 0;
			decimal TotalSalary = 0;
			bool IsLocked = false;
			DateTime Date = DateTime.MinValue;

			if (FauaterAlMakazenData.Get_FAM_info(FatoraID,ref MabiatID, ref MakazenID, ref BalataID, ref TotalSalary,ref Box, ref IsLocked, ref Date))
				return new FauaterAlMakazen(FatoraID,MabiatID, MakazenID, BalataID, TotalSalary,Box ,IsLocked, Date);
			else
				return null;
		}

		public static DataTable Getall()
		{
			return FauaterAlMakazenData.GetAll();
		}

		public static DataTable All_F_Makzan(int MakzanID)
		{
			return FauaterAlMakazenData.GetFauater_AlMakzan(MakzanID);
		}

		public static DataTable LastMonth_F(DateTime from,DateTime To)
		{
			return FauaterAlMakazenData.GetFauaterBetweenDate(from,To);
		}

		private bool _AddNewFatora()
		{
			this.FatoraID=  FauaterAlMakazenData.AddNewFatora(this.MakzanID,this.MabiatID, this.BalataID, this.TotalSalary,this.Box, this.IsLocked, this.Date);
			return (this.FatoraID > 0);
		}

		private bool _UpdateFAtora()
		{
			return FauaterAlMakazenData.UpdateFatora(this.FatoraID,this.MakzanID,this.MabiatID,this.BalataID,this.TotalSalary,this.Box,this.IsLocked,this.Date);
		}

		public bool Save()
		{
			switch (_Mode)
			{
				case Mode.Add:
					if (_AddNewFatora())
					{
						_Mode = Mode.Update;
						return true;
					}
					else
						return false;
				case Mode.Update:
					return _UpdateFAtora();
			}
			return false;
		
		}
		
		public bool Delete()
		{
			return FauaterAlMakazenData.DeleteFatora(this.FatoraID);
		}



	}
}
