using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;

namespace Sahab_Balat.GlobalClass
{
    internal class clsDate
    {

        int year {  get; set; }
        int month { get; set; }
        int day { get; set; }

        int hour { get; set; }
        int minute { get; set; }


        public bool IsLeap()
        {
           

            return (this.year / 4 == 0 && this.year / 100 != 0) || (this.year / 400 == 0);
        }

       





    }
}
