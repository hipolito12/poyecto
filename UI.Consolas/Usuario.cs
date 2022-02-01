using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios;
namespace UI.Consolas
{
    public class UsuarioConsola : Usuario_
    {


        public void menu()
        {
            UsuarioConsola uc = new UsuarioConsola();
            Console.Clear();
            Console.WriteLine("1-Listar");
            Console.WriteLine("2- Consulta ");
            Console.WriteLine("3-Agregar");
            Console.WriteLine("4-Modificar");
            Console.WriteLine("5-Eliminar");
            Console.WriteLine("6-salir");

            string opcion = Console.ReadLine();
            int op = Int32.Parse(opcion);

            switch (op)
            {
                case 1:

                    Console.Clear();
                    foreach (var item in uc.list())
                    {
                        Console.WriteLine(
                        $" Nombre completo :  {item.nombre} {item.apelldo} " +
                             $"mail: {item.email}  " +
                             $"clave: {item.clave}  " +
                             $"estado:{item.habilitado }  " +
                             $"cambio de clave :{item.cambia_clave} " +
                             $"persona: {item.id_persona} ");
                    }
                    Console.ReadLine();
                    
                    Console.Beep();
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Ingerse el id del usuario a buscar");

                    string idu = Console.ReadLine();

                    foreach (var i in uc.GetOne(idu)) 
                    {
                        Console.Write($" Nombre completo :  {i.nombre} {i.apelldo} " +
                            $"mail: {i.email}  " +
                            $"clave: {i.clave}  " +
                            $"estado:{i.habilitado }  " +
                            $"cambio de clave :{i.cambia_clave} " +
                            $"persona: {i.id_persona}  ");
                    }

                    break;




                case 3:
                    Console.Clear();
                    Console.Write("ingrese nombre Usuario  ");
                    string nombreu = Console.ReadLine();
                    Console.Write("ingrese nombre  ");
                    string nombre = Console.ReadLine();
                    Console.Write("ingrese apellido  ");
                    string apellido = Console.ReadLine();
                    Console.Write("ingrese clave  ");
                    string clave = Console.ReadLine();
                    Console.Write("ingrese nombre email  ");
                    string email = Console.ReadLine();
                    Console.Write("ingrese 1 si esta habilitado 0 si no  ");
                    string habilitado = Console.ReadLine();
                    Console.Write("ingrese 1 si cambia clave y 0 si no  ");
                    string cambiaClave = Console.ReadLine();
                    Console.Write("ingrese id_persona  ");
                    string idpersona = Console.ReadLine();

                    uc.agregegarUsuarios(idpersona, nombre, nombreu, apellido, clave, Convert.ToBoolean(Convert.ToInt32( cambiaClave)), Convert.ToBoolean(Convert.ToInt32( habilitado)), email);

                    break;
                case 4:

                    Console.Clear();
                    Console.WriteLine("ingrese id de usuario a modificar");
                    string idedit = Console.ReadLine();

                    Console.WriteLine("ingrese los nuevos datos!");

                    Console.Write("ingrese nombre Usuario");
                    string nombreusu = Console.ReadLine();
                    Console.Write("ingrese nombre");
                    string Nombre = Console.ReadLine();
                    Console.Write("ingrese apellido");
                    string Apellido = Console.ReadLine();
                    Console.Write("ingrese clave");
                    string Clave = Console.ReadLine();
                    Console.Write("ingrese nombre email");
                    string Email = Console.ReadLine();
                    Console.Write("ingrese 1 si esta habilitado 0 si no ");
                    string Habilitado = Console.ReadLine();
                    Console.Write("ingrese 1 si cambia clave y 0 si no ");
                    string CambiaClave = Console.ReadLine();
                    Console.Write("ingrese id de la persona");
                    string Idpersona = Console.ReadLine();


                    uc.editUsuarios(idedit, Idpersona, Nombre, nombreusu, Apellido, Clave, Convert.ToBoolean(CambiaClave), Convert.ToBoolean(Habilitado), Email);


                    break;

                case 5:
                    Console.Write("ingrese id del usuario");
                    string id = Console.ReadLine();

                    uc.eliminarUsuarios(id);


                    break;
                    
                case 6:
                    Console.Clear();
                    Environment.Exit(0);

                    break;
            }



        }
       

    } 
    
}
