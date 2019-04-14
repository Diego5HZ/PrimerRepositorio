using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


//Para activar el tester das click arriba en 
namespace App.Data.Test
{
    [TestClass]
    public class ArtistDAUnitTest
    {
        [TestMethod]
        public void Count()
        {
            var da = new ArtistDA();

            Assert.IsTrue(da.GetCount()>0);
        }
    }
}
