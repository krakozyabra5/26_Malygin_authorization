using _26_Malygin_authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Malygin_authorization
{
    public class Helper
    {
        private static Entities context;

        public static Entities GetContext()
        {
            if (context == null)
            {
                context = new Entities();
            }
            return context;
        }

        public Helper()
        {
            context = GetContext();
        }
    }
}
