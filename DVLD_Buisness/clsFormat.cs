using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsFormat
    {

        public static string DateToShort(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

    }
}
