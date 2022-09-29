using System;
using System.Collections.Generic;
using HerenciaPOO02.Entidades;

namespace HerenciaPOO02.Datos
{
    public class Repositorio
    {
        private List<Publicacion> lista;
        public List<Publicacion> GetLista => lista;
        public Repositorio()
        {
            lista = new List<Publicacion>();
        }
        public static bool operator ==(Repositorio r, Publicacion p)
        {
            if (p == null)
            {
                return false;
            }

            if (r.lista.Count>0)
            {
                foreach (var pub in r.lista)
                {
                    if (pub == p)
                    {
                        return true;
                    }
                }

            }          
            return false;
        }

        public static bool operator !=(Repositorio r, Publicacion p)
        {
            return !(r == p);
        }

        public static bool operator +(Repositorio r, Publicacion p)
        {

            if (r != p)
            {
                r.lista.Add(p);
                return true;

            }

            return false;
        }
        public static bool operator -(Repositorio r, Publicacion p)
        {

            if (r == p)
            {
                r.lista.Remove(p);
                return true;

            }

            return false;
        }


        public int GetCantidad => lista.Count;
    }
}
