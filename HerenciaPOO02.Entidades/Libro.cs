namespace HerenciaPOO02.Entidades
{
    public class Libro:Publicacion
    {
        private int paginas;

        public int Paginas => paginas;

        public Libro(int precio, string titulo, int paginas):base(precio,titulo)
        {
            this.paginas = paginas;
        }

        public new string MostrarDatos()
        {
            return $"{base.MostrarDatos()} - Paginas: {Paginas}";
        }
        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Libro))
            {
                return false;
                
            }

            return this.paginas == ((Libro)obj).paginas && base.Equals(obj);
        }

    }
}
