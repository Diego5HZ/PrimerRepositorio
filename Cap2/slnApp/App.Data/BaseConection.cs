using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class BaseConection
    {

        public string ConnectionString
        {
            //get
            //{
            //    string cnx = @"Data Source=MI607-ST\SQL2016PIVOT;
            //                  Initial Catalog = dbChinook;
            //                  User Id = chinook;
            //                  Password = P@$$w0rd";

            //    return cnx;
            //}

            get
            {
                string cnx = @"Data Source=DESKTOP-13T0AJD;
                              Initial Catalog = dbChinook;
                              User Id = usuario;
                              Password = sa";

                return cnx;
            }
        }

    }
}
