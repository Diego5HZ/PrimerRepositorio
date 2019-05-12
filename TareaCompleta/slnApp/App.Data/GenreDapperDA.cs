using App.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class GenreDapperDA : BaseConection
    {
        public Genre Get(int id)
        {
            var result = new Genre();
            var sql = "Select * from Genre where GenreId = @paramID";
            //$"Select * from Artist where ArtistId = {id}  <-- hazlo y te hackean :D"

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.QueryFirstOrDefault<Genre>(sql,
                    new { paramID = id });
            }

            return result;
        }

        public List<Genre> GetAllSP(string filterByName = "")
        {
            var result = new List<Genre>();
            var sql = "usp_GetAll_Genre";

            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                result = cn.Query<Genre>(sql, new { filterByName = filterByName },
                    commandType: CommandType.StoredProcedure).ToList();

            }
            return result;
        }

        public int Insert(Genre entity)
        {
            var result = 0;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.ExecuteScalar<int>("usp_InsertGenre", new { pName = entity.Name },
                    commandType: CommandType.StoredProcedure);
            }
            return result;
        }

        public int Update(Genre entity)
        {
            var result = 0;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.Execute("usp_UpdateGenre", new { pName = entity.Name, pId = entity.GenreId },
                    commandType: CommandType.StoredProcedure);

            }
            return result;
        }

        public int Delete(int id)
        {
            var result = 0;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.Execute("usp_DeleteGenre", new { pId = id },
                    commandType: CommandType.StoredProcedure);
            }
            return result;
        }
    }
}
