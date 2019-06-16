using App.Data.DataAccess;
using App.Data.Repository.Interface;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class ArtistRepository : IArtistRepository,IDisposable
    {
        protected readonly DbContext _context;

        public ArtistRepository(DbContext context)
        {
            this._context = context;
        }

        public int Add(Artist entity)
        {
            var result = 0;

            _context.Set<Artist>().Add(entity);
            _context.SaveChanges();

            result = entity.ArtistId;

            return result;
        }

        public int Count()
        {
            return _context.Set<Artist>().Count();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<Artist> GetAll()
        {
            return _context.Set<Artist>().ToList();
        }

        public Artist GetById(int id)
        {
            return _context.Set<Artist>().Find(id);
        }

        public bool Remove(Artist entity)
        {

            _context.Set<Artist>().Attach(entity);
            _context.Set<Artist>().Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Update(Artist entity)
        {
            _context.Set<Artist>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

            return true;

        }
    }
}
