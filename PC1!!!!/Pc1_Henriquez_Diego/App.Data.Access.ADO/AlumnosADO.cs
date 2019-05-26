using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace App.Data.Access
{
    public class AlumnosADO
    {
        public int Insert_Alumno(Alumno entity)
        {

            var result = 0;
            var sql = "usp_Insert_Alumnos";

            using (IDbConnection cn = new SqlConnection(this.connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@Nombres", entity.Nombres));
                cmd.Parameters.Add(
                    new SqlParameter("@Apellidos", entity.Apellidos));
                cmd.Parameters.Add(
                    new SqlParameter("@Direccion", entity.Direccion));
                cmd.Parameters.Add(
                    new SqlParameter("@Sexo", entity.Sexo));
                cmd.Parameters.Add(
                    new SqlParameter("@FechaNacimiento", entity.Apellidos));

                result = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return result;
        }

        public List<Alumno> GetAll (string filterByName = "")
        {

            var result = new List<Alumno>();
            var sql = "GetAll_Alumnos";

            using (IDbConnection cn = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cn.Open();

                cmd.Parameters.Add(
                    new SqlParameter("@filterByName", filterByName));

                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var alumno = new Alumno();
                    indice = reader.GetOrdinal("Nombre");
                    alumno.Nombres = reader.GetString(indice);

                }
            }

        }


    }
}
