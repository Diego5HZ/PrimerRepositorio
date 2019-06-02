using System;
using App.Data.Access;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.UnitTest
{
    [TestClass]
    public class EntityFrameworkUnitTest
    {
        [TestClass]
    public class ArtistDAUnitTest
    {
        [TestMethod]
        public void GetAll()
        {
            var da = new AlumnoEntityFramework();

            var lista = da.GetAll("");

            Assert.IsTrue(lista.Count > 0);
        }
    }
    }
}
