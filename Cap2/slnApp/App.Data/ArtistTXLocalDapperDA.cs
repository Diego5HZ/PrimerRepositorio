using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using Dapper;

namespace App.Data
{
    public class ArtistTXLocalDapperDA : BaseConection
    {
        public int GetCount()
        {
            //Permite obtener la cantidad de registros
            ////que existe en la tabla de artista
            //<return>Retorna el numero de registro
            var result = 0;
            var sql = "SELECT COUNT(1) FROM Artist";
            /*1.- Creando la instancia del objeto
             conection*/
            using (IDbConnection
               cn = new SqlConnection(base.ConnectionString))
            {
                result = cn.ExecuteScalar<int>(sql);
            }

            return result;
        }

        public Artista Get(int id)
        {
            var result = new Artista();
            var sql = "Select * from Artist where ArtistId = @paramID";
                    //$"Select * from Artist where ArtistId = {id}  <-- hazlo y te hackean :D"

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.QueryFirstOrDefault<Artista>(sql,
                    new { paramID = id });
            }

            return result;
        }

        public List<Artista> GetAllSP(string filterByName = "")
        {
            var result = new List<Artista>();
            var sql = "usp_GetAll";

            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                result = cn.Query<Artista>(sql, new { filterByName = filterByName },
                    commandType:CommandType.StoredProcedure).ToList();

            }
            return result;
        }/*Para hacer paso a paso pon punto rojo y en la cosa de prueba dar depurar*/

        public int Insert(Artista entity)
        {
            var result = 0;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.ExecuteScalar<int>("usp_InsertArtist", new { pName = entity.Name },
                    commandType: CommandType.StoredProcedure);
            }
            return result;
        }

        public bool Update(Artista entity)
        {
            var result = false;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.Execute("usp_UpdateArtist", new { pName = entity.Name, pId = entity.ArtistId },
                    commandType: CommandType.StoredProcedure) > 0;

            }
            return result;
        }

        public bool Delete(int id)
        {
            var result = false;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.Execute("ups_DeleteArtist", new { pId =id },
                    commandType: CommandType.StoredProcedure) > 0;
            }
            return result;
        }
    }

}
