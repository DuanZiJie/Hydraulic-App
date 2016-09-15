using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicApp
{
    class CDValueException : ApplicationException
    {
        private static string msg = "The orifice shape entered is not valid";
        public CDValueException() : base(msg) { }
    }
}
