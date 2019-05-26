using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace App.Data.Access.ADO
{
    public class TransaccionNotasDapper
    {

        public int Insert_Notas(Notas entity)
        {

            var result = 0;
            using (var tx = new TransactionScope())
            {
                using (IDbConnection cn = new SqlConnection(this.connecteionString))
                {
                    try
                    {
                        result = cn.ExecuteScalar<int>("usp_InsertNotas", new { })
                    }
                    catch (Exception)
                    {
                        result = 0;
                    }
                }
            }
            return result;
        }

    }
}
