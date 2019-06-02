using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Access
{
    public class BaseConnection
    {
        public string ConnectionString
        {
            get
            {
                string cnx = @"Data Source=MI607-ST\SQL2016PIVOT;
                              Initial Catalog = dbColegio;
                              Integrated security = true;";

                return cnx;
            }

            //get
            //{
            //    string cnx = @"Data Source=DESKTOP-13T0AJD;
            //                  Initial Catalog = dbColegio;
            //                  User Id = usuario;
            //                  Password = sa";

            //    return cnx;
            //}
        }
    }
}
