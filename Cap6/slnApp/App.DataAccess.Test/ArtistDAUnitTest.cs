using System;
using App.Data.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Data.Access.Test
{
    [TestClass]
    public class ArtistDAUnitTest
    {
        [TestMethod]
        public void GetAll()
        {
            var da = new ArtistDA();

            var lista = da.GetAll("");

            Assert.IsTrue(lista.Count > 0);
        }
    }
}
