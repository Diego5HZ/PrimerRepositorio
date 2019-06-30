using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.WCFLib.Interfaces
{
    [ServiceContract]
    public interface IMantenimientoServices
    {
        #region Artist

        [OperationContract]
        IEnumerable<Artist> GetArtistAll(string nombre);

        [OperationContract]
        int InsertArtist(Artist entity);

        [OperationContract]
        bool UpdateArtist(Artist entity);

        [OperationContract]
        bool DeleteArtist(int id);

        #endregion

        #region Album

        [OperationContract]
        IEnumerable<Album> GetAllAlbum(string nombre);

        [OperationContract]
        int InsertAlbum(Album entity);

        [OperationContract]
        bool UpdateAlbum(Album entity);

        [OperationContract]
        bool DeleteAlbum(int id);

        #endregion

        #region Customer

        [OperationContract]
        IEnumerable<Customer> GetAllCustomer(string nombre);

        [OperationContract]
        int InsertCostumer(Customer entity);

        [OperationContract]
        bool UpdateCostumer(Customer entity);

        [OperationContract]
        bool DeleteCostumer(int id);

        #endregion

        #region Employee

        [OperationContract]
        IEnumerable<Employee> GetAllEmployee(string nombre);

        [OperationContract]
        int InsertEmployee(Employee entity);

        [OperationContract]
        bool UpdateEmployee(Employee entity);

        [OperationContract]
        bool DeleteEmployee(int id);

        #endregion

        #region Genre

        [OperationContract]
        IEnumerable<Genre> GetAllGenre(string nombre);

        [OperationContract]
        int InsertGenre(Genre entity);

        [OperationContract]
        bool UpdateGenre(Genre entity);

        [OperationContract]
        bool DeleteGenre(int id);

        #endregion

        #region Invoice

        [OperationContract]
        IEnumerable<Invoice> GetAllInvoice(string nombre);

        [OperationContract]
        int InsertInvoice(Invoice entity);

        [OperationContract]
        bool UpdateInvoice(Invoice entity);

        [OperationContract]
        bool DeleteInvoice(int id);

        #endregion

        #region InvoiceLine

        [OperationContract]
        int InsertInvoiceLine(InvoiceLine entity);

        [OperationContract]
        bool UpdateInvoiceLine(InvoiceLine entity);

        [OperationContract]
        bool DeleteInvoiceLine(int id);

        #endregion

        #region MadiaType

        [OperationContract]
        IEnumerable<MediaType> GetAllMediaType(string nombre);

        [OperationContract]
        int InsertMediaType(MediaType entity);

        [OperationContract]
        bool UpdateMediaType(MediaType entity);

        [OperationContract]
        bool DeleteMediaType(int id);

        #endregion

        #region Playlist


        [OperationContract]
        IEnumerable<Playlist> GetAllPlaylist(string nombre);

        [OperationContract]
        int InsertPlaylist(Playlist entity);

        [OperationContract]
        bool UpdatePlaylist(Playlist entity);

        [OperationContract]
        bool DeletePlaylist(int id);

        #endregion

        #region Tracks

        [OperationContract]
        IEnumerable<Track> GetAllTracks(string nombre);

        [OperationContract]
        int InsertTracks(Track entity);

        [OperationContract]
        bool UpdateTracks(Track entity);

        [OperationContract]
        bool DeleteTracks(int id);

        #endregion
    }
}
