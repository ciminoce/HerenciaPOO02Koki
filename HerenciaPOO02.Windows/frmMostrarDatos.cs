using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HerenciaPOO02.Entidades;

namespace HerenciaPOO02.Windows
{
    public partial class frmMostrarDatos : Form
    {
        public frmMostrarDatos()
        {
            InitializeComponent();
        }

        private List<Publicacion> lista;
        public void SetLista(List<Publicacion> lista)
        {
            this.lista = lista;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (lista!=null)
            {
                foreach (var publicacion in lista)
                {
                    var r = new DataGridViewRow();
                    r.CreateCells(dataGridView1);
                    r.Cells[colNombre.Index].Value = publicacion.Titulo;
                    r.Cells[colPrecio.Index].Value = publicacion.Precio.ToString("C");
                    dataGridView1.Rows.Add(r);
                }
            }
        }
    }
}
