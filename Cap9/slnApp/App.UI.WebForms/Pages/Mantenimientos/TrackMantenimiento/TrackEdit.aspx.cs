using App.Data.Repository;
using App.Data.Repository.Interface;
using App.UI.WebForms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ETrack = App.Entities.Base;

namespace App.UI.WebForms.Pages.Mantenimientos.Track
{
    public partial class TrackEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitValues();
        }

        private void InitValues()
        {
            IAppUnitOfWork uw = new AppUnitOfWork();
            var albums = uw.AlbumRepository.GetAll();
            //ddlAlbum.DataTextField = "Title";
            //ddlAlbum.DataValueField = "AlbumId";
            //ddlAlbum.DataSource = albums;
            //ddlAlbum.DataBind();

            Helpers.ConfigurarCombo(ddlAlbum, "Title", "AlbumId", albums);


            var media = uw.MediaTypeRepository.GetAll();
            //ddlMedio.DataTextField = "Name";
            //ddlMedio.DataValueField = "MediaTypeId";
            //ddlMedio.DataSource = media;
            //ddlMedio.DataBind();

            Helpers.ConfigurarCombo(ddlMedio, "Name", "MediaTypeId", media);

            var genre = uw.GenreRepository.GetAll();
            //ddlGenero.DataTextField = "Name";
            //ddlGenero.DataValueField = "GenreId";
            //ddlGenero.DataSource = genre;
            //ddlGenero.DataBind();

            Helpers.ConfigurarCombo(ddlGenero, "Name", "GenreId", genre);
            uw.Dispose();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void guardar()
        {
            var entity = new ETrack.Track();
            entity.Name = txtNombre.Text;
            entity.AlbumId = Convert.ToInt32(ddlAlbum.SelectedValue);
            entity.MediaTypeId = Convert.ToInt32(ddlMedio.SelectedValue);
            entity.GenreId = Convert.ToInt32(ddlMedio.SelectedValue);
            entity.Composer = txtCompositor.Text;
            entity.Milliseconds = Convert.ToInt32(txtDuracion.Text);
            entity.Bytes = Convert.ToInt32(txtPeso.Text);
            entity.UnitPrice = Convert.ToDecimal(txtPrecio.Text);

            IAppUnitOfWork uw = new AppUnitOfWork();

            uw.TrackRepository.Add(entity);
            uw.Complete();

            uw.Dispose();
        }
    }
}