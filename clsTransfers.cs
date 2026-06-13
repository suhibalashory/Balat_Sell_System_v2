using BissnussLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkirat2.GlobalClass
{
	public  class clsTransfers
	{

		public static int FromMeterToBoxis(float Meter,float MeterInBox)
		{
			return (int)Math.Round(Meter / MeterInBox);
		}

	
		public static DataTable convertToTable(List<FauaterAlMakazen> Fauater)
		{
			/*
			 * Balat code 
			 * Boxing
			 * total salary 
			 * Albaqy 
			 */

			if(Fauater.Count == 0) return null;

			DataTable table = new DataTable();

			table.Columns.Add("Balat ID",typeof(int));
			table.Columns.Add("Balat Code", typeof(string));
			table.Columns.Add("Boxing", typeof(int));
			table.Columns.Add("Total Salary", typeof(Decimal));

			Fauater.ForEach(x => 
			table.Rows.Add(x.BalataID,clsBalata.Find(x.BalataID).Code,x.Box,x.TotalSalary));

			return table;
		}




		
	}
}
