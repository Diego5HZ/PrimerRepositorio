using System;
using System.Linq;
using App.Data.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Data.Access.Test
{
    [TestClass]
    public class TrackDAUnitTest
    {
        [TestMethod]
        public void ConsultarTracks()
        {
            var da = new TrackDA();
            var listado = da.ConsultarTracks("%VOLTA%");

            //                      v- para usar el count tengo que agregar la referencia de linq
            Assert.IsTrue(listado.Count() > 0);
        }

        [TestMethod]
        public void ConsultarTrackQ()
        {
            var da = new TrackDA();
            var listado = da.ConsultarTrackQ("%VOLTA%",0,0);

            //                      v- para usar el count tengo que agregar la referencia de linq
            Assert.IsTrue(listado.Count() > 0);
        }
    }
}
