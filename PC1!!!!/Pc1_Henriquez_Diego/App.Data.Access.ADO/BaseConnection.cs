using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Access
{
    public class BaseConection
    {
        public string connectionString
        {
            get
            {
                string cnx = @"Data Source=DESKTOP-13T0AJD;
                              Initial Catalog = dbChinook;
                              Integrated Security = true";

                return cnx;
            }
        }
    }
}