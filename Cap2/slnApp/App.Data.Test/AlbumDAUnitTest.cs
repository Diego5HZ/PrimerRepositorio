using System;
using App.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Data;

namespace App.Data.Test
{
    [TestClass]
    public class AlbumDAUnitTest
    {
        [TestMethod]
        public void Get()
        {
            var da = new AlbumDA();
            var entity = da.Get(20);

            Assert.IsTrue(entity.AlbumId > 0);
        }

        [TestMethod]
        public void GetAll()
        {
            var da = new AlbumDA();
            var listado = da.GetAll("Origin");

            Assert.IsTrue(listado.Count > 0);
        }

        [TestMethod]
        public void Insert()
        {
            var da = new AlbumDA();
            var album = new Album();
            album.Title = "NEWONE";
            album.ArtistId = (34);
            var id = da.Insert(album);

            Assert.IsTrue(id > 0,"El nombre del Album ya existe");
        }
        [TestMethod]
        public void Update()
        {
            var da = new AlbumDA();
            var album = new Album();
            album.Title = "NdsdwL";
            album.AlbumId = 354;
            var registrosAfectado = da.Update(album);

            Assert.IsTrue(registrosAfectado > 0, "El nombre del Album ya existe");
        }
    }
}
