/*using System;
using datos;
namespace UI.consola
{
    public class consolaMaterias : Materia
    {
        public void Menu()
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
            Materia a = new Materia();
            switch (option)
            {
                case 1:
                    a.listado();
                    break;
                case 2:

                    break;
                case 3:
                    string desc = Console.ReadLine();
                    int t = Convert.ToInt32(Console.ReadLine());
                    int s = Convert.ToInt32(Console.ReadLine());
                    int p = Convert.ToInt32(Console.ReadLine());

                    a.insertt(desc, t, s, p);


                    break;




                case 4:
                    string descr = Console.ReadLine();
                    int te = Convert.ToInt32(Console.ReadLine());
                    int ese = Convert.ToInt32(Console.ReadLine());
                    int pe = Convert.ToInt32(Console.ReadLine());
                    int ide = Convert.ToInt32(Console.ReadLine());
                    a.update(descr, te, ese, pe, ide);




                    break;
                case 5:
                    int id = Convert.ToInt32(Console.ReadLine());
                    a.Eliminar(id);


                    break;



                case 6:
                    break;
            }
        }
    }
}
            
     */





