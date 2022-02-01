using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios;
namespace UI.Consolas
{
    public class Materias : Materia_n

    {

        public class consolaMaterias : Materia_n
        {
            public void Menu()
            {
                consolaMaterias cm = new consolaMaterias();

                Console.Clear();

                Console.WriteLine("1- Listado");
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
                                Console.WriteLine(" ");
                                Console.WriteLine($"|{items.desc_materia}|{items.idmateria} ||{items.hs_semanales} ||{items.hs_totales} ||{items.id_plan} |");
                            }
                            Console.ReadLine();


                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }

                        break;


                    case 2:

                        Console.Clear();
                        Console.WriteLine("ingrese la el id de la materia a consultar");
                        string ide = Console.ReadLine();

                        foreach (var item in cm.GetOne(ide)) 
                        {
                            Console.WriteLine($"{item.desc_materia} {item.hs_semanales} {item.hs_totales} {item.id_plan}");
                        }
                        
                        
                        
                        break;

                    case 3:


                        try
                        {

                            Console.Clear();


                            Console.WriteLine("ingrese los  datos !");

                            Console.Write("ingrese descripcion de la materia");
                            string descrip = Console.ReadLine();
                            Console.Write("ingrese horas semanales");
                            string semanal = Console.ReadLine();
                            Console.Write("ingrese horas totales");
                            string total = Console.ReadLine();
                            Console.Write("ingrese id del  plan");
                            string plan = Console.ReadLine();





                            cm.agregarmateria(descrip, semanal, total, plan);

                        }
                        catch (Exception ex)
                        {

                            throw ex;
                        }


                        break;


                    case 4:

                        Console.Clear();
                        Console.WriteLine("ingrese id de materia a modificar");
                        string idedit = Console.ReadLine();

                        Console.WriteLine("ingrese los nuevos datos!");

                        Console.Write("ingrese descripcion de la materia");
                        string descripcion = Console.ReadLine();
                        Console.Write("ingrese horas semanales");
                        string Semanal = Console.ReadLine();
                        Console.Write("ingrese horas totales");
                        string Total = Console.ReadLine();
                        Console.Write("ingrese id del  plan");
                        string Plan = Console.ReadLine();

                        cm.EditarMaterias(descripcion, idedit, Semanal, Total, Plan);

                        break;




                    case 5:
                        Console.WriteLine("ingrese id de la materia a eliminar");
                        string id = Console.ReadLine();
                        cm.eliminarMateria(id);


                        break;



                    case 6:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }



            }



        }
    }
}
