using System;

using System.Data;
using System.Data.SqlClient;
using CapaNegocios;


namespace UI.consola
{
    public class consolaMaterias : Materia_n
    {
        public void Menu()
        {
            consolaMaterias cm = new consolaMaterias();

            Console.Clear();
            Console.WriteLine("1- Listado general");
            Console.WriteLine("2- Consulta");
            Console.WriteLine("3- Agregar");
            Console.WriteLine("4- Modificar");
            Console.WriteLine("5- Eliminar");
            Console.WriteLine("6- Salir");

            int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:

                    try
                    {
                        foreach (var items in cm.lista())
                        {
                            Console.WriteLine($"|{items.idmateria} ||{items.horas_semanales} ||{items.horas_totales} ||{items.idplan} |");
                        }


                    }
                    catch (Exception ex)
                    {

                    }

                       break;




                case 2:



                    cm.agregarmateria("materiaConsola","15","30","1");

                    break;
            //    case 5:
            //        int id = Convert.ToInt32(Console.ReadLine());
            //        a.Eliminar(id);


            //        break;



            //    case 6:
            //        break;
            }



        }

        static void Main(string[] args)
        {
            consolaMaterias cm = new consolaMaterias();
            cm.Menu();
        }

    }
}







