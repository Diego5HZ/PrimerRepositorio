using App.Data.DataAccess;
using App.Data.Repository;
using App.Data.Repository.Interface;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.Desktop
{
    public partial class frmReporteTracks : Form
    {

        public frmReporteTracks()
        {
            InitializeComponent();

            InicializarValores();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        #region "Procedimientos propios"
        private void Buscar()
        {
            IAppUnitOfWork uw = new AppUnitOfWork();
            var listado = uw.TrackRepository.ReporteTracks
                (txtNombre.Text.Trim());

            gvListado.DataSource = listado;
            gvListado.Refresh();

        }

        private void InicializarValores()
        {
            //Obteniendo información de géneros
            IAppUnitOfWork uw = new AppUnitOfWork();

            var genreListado = uw.GenreRepository.GetAll().ToList();

            genreListado.Insert(0,new
                Genre()
            {
                GenreId=0,
                Name="Todos"
            });
           
            cboGeneros.DataSource = genreListado;
            cboGeneros.Refresh();

            //Obteniendo información de Media Type
            var mediaListado = uw.MediaTypeRepository.GetAll().ToList();

            mediaListado.Insert(0, new
                MediaType()
            {
                MediaTypeId = 0,
                Name = "Todos"
            });

            //Libera espacio que se usa para generar la conexion
            uw.Dispose();

            cboMediaType.DataSource = mediaListado;
            cboMediaType.Refresh();
        }
        #endregion


    }
}
