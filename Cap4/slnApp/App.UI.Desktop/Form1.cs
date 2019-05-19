using App.Data.DataAccess;
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
    public partial class frmConsultaTracks : Form
    {
        public frmConsultaTracks()
        {
            InitializeComponent();

            InicializarValoresGenero();
            InicializarValoresMediaType();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

#region "Procedimientos propios"
        private void Buscar()
        {
            var trackDA = new TrackDA();
            var listado = trackDA
                .ConsultarTrackQ(txtNombre.Text.Trim(), (int)cboGenero.SelectedValue, (int)cboMedia.SelectedValue);
            gvListado.DataSource = listado;
            gvListado.Refresh();

        }

        private void InicializarValoresGenero()
        {
            //Obteniendo información de generos
            var genreDA = new GenreDA();
            var genreListado = genreDA.GetAll().ToList();

            genreListado.Insert(0, new
                Genre()
            {
                GenreId = 0,
                Name = "Todos"
            });

            cboGenero.DataSource = genreListado;
            cboGenero.Refresh();
        }

        private void InicializarValoresMediaType()
        {
            //Obteniendo informacion de media
            var mediaDA = new MediaTypeDA();
            var mediaTypeListado = mediaDA.GetAll().ToList();

            mediaTypeListado.Insert(0, new
                MediaType()
            {
                MediaTypeId = 0,
                Name = "Todos"
            });

            cboMedia.DataSource = mediaTypeListado;
            cboMedia.Refresh();
        }
#endregion
    }
}
