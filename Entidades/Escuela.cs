using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        private string nombre = "";
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        } 

        public int AñoDeCreación { get; set; }       
        public string Pais { get; set; } = "";
        public string Ciudad { get; set; } = "";
        public TiposEscuela TipoEscuela { get; set; }

        public Curso[] Cursos { get; set; }


        // public Escuela(string nombre, int año, string pais)
        // {
        //     this.nombre = nombre;
        //     AñoDeCreación = año;
        //     Pais = pais;
        // }
        public Escuela(string nombre,
                       int año,
                       string pais) => (Nombre, AñoDeCreación) = (nombre, año);
        
        public Escuela(string nombre,
                       int año,
                       TiposEscuela tipo,
                       string pais = "",
                       string ciudad = "")
        {
            (Nombre, AñoDeCreación, Pais, Ciudad) = (nombre, año, pais, ciudad);
            TipoEscuela = tipo;
        }            




        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela}{System.Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}