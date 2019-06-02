using App.Entities.Dapper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Access
{
    public class NotasDapper: BaseConnection
    {
        public int Insert(Notas entity)
        {
            var result = 0;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.ExecuteScalar<int>("usp_Insert_Notas", new { pAlumnoId = entity.AlumnoID , pCursoId = entity.CursoID, pNota = entity.Nota},
                    commandType: CommandType.StoredProcedure);
            }
            return result;
        }
    }
}
