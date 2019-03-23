using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Eticaret.MvcWebUI.Models;

namespace Eticaret.MvcWebUI.App_Classes
{
    public class Context
    {
       
        private static ETicaret2018Context baglanti;

        public static ETicaret2018Context Baglanti
        {

            get
            {
                if (baglanti == null)
                    baglanti = new ETicaret2018Context();
                return baglanti;
            }
            set { baglanti = value; }
        }

}
    
   
}
