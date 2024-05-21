using System;
using System.Collections.Generic;
using System.Linq;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };

            #region Ejercicio1
            // Detectar cual es el numero mas grande e imprimirlo por consola
            var lstNumeros = new List<int>() { 25, 10, 99, 105, 1, 84, 22 };
            int maxNumero = lstNumeros.Max();
            Console.WriteLine($"El número más grande es: {maxNumero}");
            #endregion

            #region Ejercicio2
            // Ordenar los nombres alfabeticamente
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };
            var nombresOrdenados = lstNombres.OrderBy(n => n).ToList();
            Console.WriteLine("Nombres ordenados alfabéticamente:");
            foreach (var nombre in nombresOrdenados)
            {
                Console.WriteLine(nombre);
            }
            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola
            var clientesVip = lstClientes.Where(c => c.Vip).ToList();
            Console.WriteLine("Clientes VIP:");
            foreach (var cliente in clientesVip)
            {
                Console.WriteLine($"{cliente.Nombre} {cliente.Apellido}");
            }
            #endregion

            #region Ejercicio4 
            // Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            var nombresClientes = lstClientes.Select(c => c.Nombre).ToList();
            Console.WriteLine("Nombres de los clientes:");
            foreach (var nombre in nombresClientes)
            {
                Console.WriteLine(nombre);
            }
            #endregion

            #region Ejercicio5
            // Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"
            var clientesModificados = lstClientes.Select(c => new
            {
                CodCliente = c.CodCliente,
                Nombre = c.Nombre.ToUpper(),
                Apellido = c.Apellido.ToUpper(),
                Vip = c.Vip ? "Premium" : "Normal"
            }).ToList();
            Console.WriteLine("Clientes modificados:");
            foreach (var cliente in clientesModificados)
            {
                Console.WriteLine($"CodCliente: {cliente.CodCliente}, Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, Vip: {cliente.Vip}");
            }
            Console.ReadLine();
            #endregion
        }
    }

   
}
