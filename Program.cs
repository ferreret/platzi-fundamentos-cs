// See https://aka.ms/new-console-template for more information
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

var engine = new EscuelaEngine();
ImprimirCursosEscuela(engine.Escuela);

// -------------------------------------------------------------------------------------------------------------------------
/// <summary>
/// 
void ImprimirCursosEscuela(Escuela escuela)
{

    Printer.DibujarTitulo("Cursos de la Escuela");

    if (escuela?.Cursos != null)
    {
        foreach (var curso in escuela.Cursos)
        {
            WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
        }
    }

}

