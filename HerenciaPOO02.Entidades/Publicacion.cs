using System;

namespace HerenciaPOO02.Entidades
{
    public class Publicacion
    {
        public int Precio { get;}
        public string Titulo { get;}


        public Publicacion(int precio, string titulo)
        {
            Precio = precio;
            Titulo=titulo;
        }

        public string MostrarDatos()
        {
            return $"Titulo: {Titulo} - Precio: {Precio}";
        }

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Publicacion))
            {
                return false;
            }
            return this.Precio == ((Publicacion)obj).Precio && this.Titulo == ((Publicacion)obj).Titulo;
        }

        public static bool operator ==(Publicacion p1, Publicacion p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Publicacion p1, Publicacion p2)
        {
            return !(p1 == p2);
        }
    }
}
