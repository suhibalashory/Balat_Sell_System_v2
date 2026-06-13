using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using	BissnussLayer;


namespace Alkirat2.GlobalClass
{
	public class Global
	{

		public static BissnussLayer.clsUser  CurrentUser { get; set; }

		public static string sha256(string input)
		{
			using(SHA256 sha256 = SHA256.Create())
			{
				byte[] hashbyte = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
				return BitConverter.ToString(hashbyte).Replace("-","").ToLower();
			}
		}


	}
}
