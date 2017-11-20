using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra09
{
    public class Kiuas
    {
        public string temp
        {
            get
            {
                return temp;
            }
            set
            {
                float f = float.Parse(value);
                if (f > 120) temp = "120";
                else if (f < 0) temp = "0";
                else temp = value;

            }
        }
        public string hum
        {
            get { return hum; }
            set
            {
                float f = float.Parse(value);
                if (f > 100) hum ="100";
                else if (f < 0) hum = "0";
                else hum = value;
            }
        }
       
        
    }
}
