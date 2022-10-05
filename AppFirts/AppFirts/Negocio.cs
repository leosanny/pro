
using System;
using System.Collections.Generic;

namespace AppFirst
{
    public class Negocio
    {
        public void insertar()
        {
            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese documento de identidad: ");
            string documentoIdentidad = Console.ReadLine();

            Console.WriteLine("Ingrese sexo: ");
            bool sexo = Console.ReadLine() == "M" ? true : false;

            Console.WriteLine("Ingrese fecha de nacimiento: ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese estatura: ");
            float estatura = float.Parse(Console.ReadLine());

            Persona persona = new Persona();

            persona.nombre = nombre;
            persona.apellido = apellido;
            persona.documentoIdentidad = documentoIdentidad;
            persona.sexo = sexo;
            persona.fechaNacimiento = fechaNacimiento;
            persona.estatura = estatura;
            persona.fechaRegistro = DateTime.Now;
            persona.fechaModificacion = DateTime.Now;

            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.create(persona))
            {
                Console.WriteLine("Datos registrados correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo registrar los datos.");
            }
        }

        public void listar()
        {
            IAccesoDatos iAccesoDatos = new AccesoDatos();

            List listaPersona = iAccesoDatos.read();

            int i = 1;

            foreach (Persona item in listaPersona)
            {
                Console.WriteLine(string.Concat(i, ". ", item.nombre, "---", item.apellido, "---", item.documentoIdentidad, "---", item.sexo, "---", item.fechaNacimiento, "---", item.estatura, "---", item.fechaRegistro, "---", item.fechaModificacion));

                i++;
            }
        }

        public void editar()
        {
            listar();

            Console.WriteLine();
            Console.WriteLine("Ingrese el nro de la persona que desea editar:");
            int posicionPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese documento de identidad: ");
            string documentoIdentidad = Console.ReadLine();

            Console.WriteLine("Ingrese sexo: ");
            bool sexo = Console.ReadLine() == "M" ? true : false;

            Console.WriteLine("Ingrese fecha de nacimiento: ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese estatura: ");
            float estatura = float.Parse(Console.ReadLine());

            Persona persona = new Persona();

            persona.nombre = nombre;
            persona.apellido = apellido;
            persona.documentoIdentidad = documentoIdentidad;
            persona.sexo = sexo;
            persona.fechaNacimiento = fechaNacimiento;
            persona.estatura = estatura;
            persona.fechaModificacion = DateTime.Now;

            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.update(persona, posicionPersona))
            {
                Console.WriteLine("Datos modificados correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo modificar los datos.");
            }
        }

        public void eliminar()
        {
            listar();

            Console.WriteLine();
            Console.WriteLine("Ingrese el documento de identidad de la persona que desea eliminar:");
            string documentoIdentidad = Console.ReadLine();

            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.delete(documentoIdentidad))
            {
                Console.WriteLine("Persona eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar los datos porque la persona no existe.");
            }
        }
    }
}
