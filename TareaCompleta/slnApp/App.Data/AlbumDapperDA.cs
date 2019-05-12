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
    public class AlbumDapperDA : BaseConection
    {
        public Album Get(int id)
        {
            var result = new Album();
            var sql = "Select * from Album where AlbumId = @paramID";
            //$"Select * from Artist where ArtistId = {id}  <-- hazlo y te hackean :D"

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.QueryFirstOrDefault<Album>(sql,
                    new { paramID = id });
            }

            return result;
        }
        public List<Album> GetAllSP(string filterByName = "")
        {
            var result = new List<Album>();
            var sql = "usp_GetAll_Album";

            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                result = cn.Query<Album>(sql, new { filterByName = filterByName },
                    commandType: CommandType.StoredProcedure).ToList();

            }
            return result;
        }

        public int Insert(Album entity)
        {
            var result = 0;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.ExecuteScalar<int>("usp_InsertAlbum", new { pTitle = entity.Title, pArtistId = entity.ArtistId },
                    commandType: CommandType.StoredProcedure);
            }
            return result;
        }

        public int Update(Album entity)
        {
            var result = 0;
            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                result = cn.Execute("usp_UpdateAlbum", new { pName = entity.Title, pId = entity.AlbumId },
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
                result = cn.Execute("usp_DeleteAlbum", new { pId = id },
                    commandType: CommandType.StoredProcedure);
            }
            return result;
        }
    }
}
