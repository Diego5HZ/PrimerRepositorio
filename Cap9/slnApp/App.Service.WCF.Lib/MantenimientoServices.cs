using App.Data.Repository;
using App.Entities.Base;
using App.Service.WCFLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.WCF.Lib
{
    public class MantenimientoServices : IMantenimientoServices
    {
        #region Artist
        public IEnumerable<Artist> GetArtistAll(string nombre)
        {
            var result = new List<Artist>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.ArtistRepository.GetAll(
                    item => item.Name.Contains(nombre)
                    );
            }
            return result;
        }

        public int InsertArtist(Artist entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                //Siempre q se usa add se tiene que poner sí o sí el complete
                uw.ArtistRepository.Add(entity);
                uw.Complete();

                result = entity.ArtistId;
            }
            return result;
        }

        public bool UpdateArtist(Artist entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.ArtistRepository.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        public bool DeleteArtist(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new Artist()
                {
                    ArtistId = id
                };
                uw.ArtistRepository.Remove(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }
        #endregion

        #region Album
        public IEnumerable<Album> GetAllAlbum(string nombre)
        {
            var result = new List<Album>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.AlbumRepository.GetAll(
                    item => item.Title.Contains(nombre));
            }
            return result;
        }

        public int InsertAlbum(Album entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.AlbumRepository.Add(entity);
                uw.Complete();

                result = entity.ArtistId;
            }
            return result;
        }

        public bool UpdateAlbum(Album entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.AlbumRepository.Update(entity);
                uw.Complete();
                result = true;
            }
            return result;
        }
        public bool DeleteAlbum(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new Album()
                {
                    AlbumId = id
                };
                uw.AlbumRepository.Remove(entity);
                uw.Complete();
            }
            return result;
        }
        #endregion

        #region Customer

        public IEnumerable<Customer> GetAllCustomer(string nombre)
        {
            var result = new List<Customer>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.CustomerRepository.GetAll(
                    item => item.Company.Contains(nombre));
            }
            return result;
        }

        public int InsertCostumer(Customer entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.CustomerRepository.Add(entity);
                uw.Complete();

                result = entity.CustomerId;
            }
            return result;
        }

        public bool UpdateCostumer(Customer entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.CustomerRepository.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        public bool DeleteCostumer(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new Customer()
                {
                    CustomerId = id
                };
                uw.CustomerRepository.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        #endregion

        #region Employee

        public IEnumerable<Employee> GetAllEmployee(string nombre)
        {
            var result = new List<Employee>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.EmployeeRepository.GetAll(
                    item => item.LastName.Contains(nombre));
            }
            return result;
        }

        public int InsertEmployee(Employee entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.EmployeeRepository.Add(entity);
                uw.Complete();

                result = entity.EmployeeId;
            }
            return result;
        }

        public bool UpdateEmployee(Employee entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.EmployeeRepository.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        public bool DeleteEmployee(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new Employee()
                {
                    EmployeeId = id
                };
                uw.EmployeeRepository.Remove(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        #endregion

        #region Genre

        public IEnumerable<Genre> GetAllGenre(string nombre)
        {
            var result = new List<Genre>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.GenreRepository.GetAll(
                    item => item.Name.Contains(nombre));
            }
            return result;
        }

        public int InsertGenre(Genre entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.GenreRepository.Add(entity);
                uw.Complete();

                result = entity.GenreId;
            }
            return result;
        }

        public bool UpdateGenre(Genre entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.GenreRepository.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        public bool DeleteGenre(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new Genre()
                {
                    GenreId = id
                };
                uw.GenreRepository.Remove(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        #endregion

        #region Invoice

        public IEnumerable<Invoice> GetAllInvoice(string nombre)
        {
            var result = new List<Invoice>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.InvoiceReposiroty.GetAll(
                    item => item.BillingCountry.Contains(nombre));
            }
            return result;
        }

        public int InsertInvoice(Invoice entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.InvoiceReposiroty.Add(entity);
                uw.Complete();

                result = entity.InvoiceId;
            }
            return result;
        }

        public bool UpdateInvoice(Invoice entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.InvoiceReposiroty.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        public bool DeleteInvoice(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new Invoice()
                {
                    InvoiceId = id
                };
                uw.InvoiceReposiroty.Remove(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        #endregion

        #region InvoiceLine
        //TERMINARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR

        public int InsertInvoiceLine(InvoiceLine entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.InvoiceLineRepository.Add(entity);
                uw.Complete();

                result = entity.InvoiceLineId;
            }
            return result;
        }

        public bool UpdateInvoiceLine(InvoiceLine entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.InvoiceLineRepository.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        public bool DeleteInvoiceLine(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new InvoiceLine()
                {
                    InvoiceLineId = id
                };
                uw.InvoiceLineRepository.Remove(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }
        #endregion

        #region MadiaType

        public IEnumerable<MediaType> GetAllMediaType(string nombre)
        {
            var result = new List<MediaType>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.MediaTypeRepository.GetAll(
                    item => item.Name.Contains(nombre));
            }
            return result;
        }

        public int InsertMediaType(MediaType entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.MediaTypeRepository.Add(entity);
                uw.Complete();

                result = entity.MediaTypeId;
            }
            return result;
        }

        public bool UpdateMediaType(MediaType entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.MediaTypeRepository.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        public bool DeleteMediaType(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new MediaType()
                {
                    MediaTypeId = id
                };
                uw.MediaTypeRepository.Remove(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }
        #endregion

        #region Playlist

        public IEnumerable<Playlist> GetAllPlaylist(string nombre)
        {
            var result = new List<Playlist>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.PlaylistRepository.GetAll(
                    item => item.Name.Contains(nombre));
            }
            return result;
        }

        public int InsertPlaylist(Playlist entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.PlaylistRepository.Add(entity);
                uw.Complete();

                result = entity.PlaylistId;
            }
            return result;
        }

        public bool UpdatePlaylist(Playlist entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.PlaylistRepository.Update(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }

        public bool DeletePlaylist(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new Playlist()
                {
                    PlaylistId = id
                };
                uw.PlaylistRepository.Remove(entity);
                uw.Complete();

                result = true;
            }
            return result;
        }
        #endregion

        #region Tracks

        public IEnumerable<Track> GetAllTracks(string nombre)
        {
            var result = new List<Track>();
            using (var uw = new AppUnitOfWork())
            {
                result = uw.TrackRepository.GetAll(
                    item => item.Composer.Contains(nombre));
            }
            return result;
        }

        public int InsertTracks(Track entity)
        {
            var result = 0;
            using (var uw = new AppUnitOfWork())
            {
                uw.TrackRepository.Add(entity);
                uw.Complete();

                result = entity.TrackId;
            }
            return result;
        }

        public bool UpdateTracks(Track entity)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                uw.TrackRepository.Update(entity);
                uw.Complete();

                result = false;
            }
            return result;
        }

        public bool DeleteTracks(int id)
        {
            var result = false;
            using (var uw = new AppUnitOfWork())
            {
                var entity = new Track()
                {
                    TrackId = id
                };
                uw.TrackRepository.Remove(entity);
                uw.Complete();

                result = false;
            }
            return result;
        }

        #endregion
    }
}
