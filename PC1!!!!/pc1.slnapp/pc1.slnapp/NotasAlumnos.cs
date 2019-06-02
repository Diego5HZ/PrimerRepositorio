using App.Entities.Queries;
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
    public class NotasAlumnos:BaseConnection
    {
        public List<Notas_Alumnos> ConsultarNotas(string Curso, string Grado)
        {
            var result = new List<Notas_Alumnos>();
            var sql = "usp_GetNotasAlumnos";
            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                result = cn.Query<Notas_Alumnos>(sql, new { pCurso = Curso, pGrado = Grado},
                    commandType:CommandType.StoredProcedure).ToList();
            }
            return result;
        }
    }
}
