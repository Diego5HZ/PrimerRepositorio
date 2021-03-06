﻿using System;
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
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void reporteDeTrakcsConRepositoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmConsultaTracks();
            {
                form.MdiParent = this;
            }
            form.Show();

            // De preferencia usar el comentado porque sale si osi
            //form.MdiParent = this;
            //form.Show();
        }

        private void reporteDeTracksConRepositoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmReporteTracks();
            {
                form.MdiParent = this;
            }
            form.Show();
        }
    }
}
