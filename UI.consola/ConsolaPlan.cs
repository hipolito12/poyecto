using System;
using System.Collections.Generic;
using System.Text;
using datos;

namespace UI.consola
{
    class ConsolaPlan : Plan
    {
        static public void Menu()
        {


            Console.Clear();
            Console.WriteLine("1- Listado general");
            Console.WriteLine("2- Consulta");
            Console.WriteLine("3- Agregar");
            Console.WriteLine("4- Modificar");
            Console.WriteLine("5- Eliminar");
            Console.WriteLine("6- Salir");

            int option;
            option = Convert.ToInt32(Console.ReadLine());
          Plan pla = new Plan();
            switch (option)
            {
                case 1:
                    pla.listadop();
                    break;
                case 2:
                    int id = Convert.ToInt32(Console.ReadLine());
                    pla.consultap(id);

                    break;
                case 3:
                    string descr = Console.ReadLine();
                    int esp = Convert.ToInt32(Console.ReadLine());
                    

                    pla.insertp(descr, esp );


                    break;




                case 4:
                    string descri = Console.ReadLine();
                    int  espe= Convert.ToInt32(Console.ReadLine());
                    int ide = Convert.ToInt32(Console.ReadLine());
                    
                    pla.updatep(descri, espe , ide);




                    break;

                case 5:
                     int iden = Convert.ToInt32(Console.ReadLine());
                    

                    pla.Eliminarp(iden);


                    break;



                case 6: Console.WriteLine(" terminamos UwU");
                    break;
            }
        }




    }
}
