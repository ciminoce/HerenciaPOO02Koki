using System;
using System.Windows.Forms;
using HerenciaPOO02.Datos;
using HerenciaPOO02.Entidades;

namespace HerenciaPOO02.Windows
{
    public partial class frmIngresoDatos : Form
    {
        public frmIngresoDatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
        }
        private Repositorio repositorio;

        private Publicacion publicacion;
        private Libro libro;
        private AudioLibro audioLibro;
        private void CapturarDatosButton_Click(object sender, EventArgs e)
        {
            if (LibroImpresoRadioButton.Checked)
            {
                libro = new Libro(int.Parse(this.PrecioTextBox.Text), this.TituloTextBox.Text, int.Parse(this.PaginasTextBox.Text));
                publicacion = libro;
            }
            else
            {
                audioLibro=new AudioLibro(int.Parse(this.PrecioTextBox.Text), this.TituloTextBox.Text, int.Parse(this.TiempoTextBox.Text));
                publicacion=audioLibro;
            }

            if (repositorio+publicacion)
            {
                MessageBox.Show("Publicación agregada");
                publicacion = null;
                libro = null;
            }
            else
            {
                MessageBox.Show("Publicación existente!!!");
                publicacion = null;
                audioLibro = null;
            }
        }

        private void MostrarDatosButton_Click(object sender, EventArgs e)
        {
            frmMostrarDatos frm = new frmMostrarDatos();
            frm.SetLista(repositorio.GetLista);
            frm.ShowDialog(this);
        }
    }
}
