using System;
using System.Linq;
using App.Data.DataAccess;
using App.Data.Repository;
using App.Data.Repository.Interface;
using App.Entities.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Data.DataAccessTest
{
    [TestClass]
    public class ArtistRepositoryTest
    {
        [TestMethod]
        public void GetAll()
        {
            int totalRows = 0;
            int totalAlmbumRows = 0;

            using (var repository = new AppUnitOfWork())
            {
                totalRows = repository.GetAll().Count();
                totalAlmbumRows = repository.AlbumRepository.GetAll.Count();
            }

            Assert.IsTrue(totalRows > 0 && totalAlmbumRows > 0);

        }

        [TestMethod]
        public void InserArtist()
        {
            var result = false;

            using (var uw = new AppUnitOfWork())
            {
                var newArtist = new Artist()
                {
                    Name = "Album nuevo"
                };

                uw.ArtistRepository.Add(newArtist);
                result = uw.Complete() > 0;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InserAlbum()
        {
            var result = false;

            using (var uw = new AppUnitOfWork())
            {
                var newArtist = new Artist()
                {
                    Name = "Album nuevo"
                };

                var newAlbum = new Album()
                {
                    Title = "Album nuevo",
                    Artist = newArtist
                };

                uw.AlbumRepository.Add(newAlbum);
                result = uw.Complete() > 0;
            }
            Assert.IsTrue(result);
        }

    }
}
