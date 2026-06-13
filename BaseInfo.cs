using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BissnussLayer
{
    public class BaseInfo
    {

        int  BaseInfoID {  get; set; }
        public string StoreName { get; set; }
        public string Phone {  get; set; }
        public string Location { get; set; }
        public decimal StoreRent { get; set; }

         BaseInfo()
        { }


        public static BaseInfo getBaseInfo()
        {
            return new BaseInfo()
            {
                BaseInfoID = 0,
                StoreName = "السمسم",
                Phone = "0927363944",
                Location = "tripoly",
                StoreRent = 1000
            };
        }
    }
}
