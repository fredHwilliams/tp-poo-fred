using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Salarie Sala1 = new Salarie();
            //Sala1.NomSalarie = "";
            //Sala1.Salaire = 250;
            //Sala1.Matricule = 1;
            //Sala1.Serv = 5;
            //Sala1.Ctg = 1;
            //Sala1.CalculerSalaire();



            //Salarie Sala2 = new Salarie();
            //Sala2.NomSalarie = "marie-Jenifer";
            //Sala2.Salaire = 2350.0;
            //Sala2.Serv = 5;
            //Sala2.Ctg = 1;
            //Sala2.CalculerSalaire();


            //Salarie Sala3 = new Salarie();
            //Sala3.NomSalarie = "Tintin";
            //Sala3.Salaire = 12000;
            //Sala3.Serv = 4;
            //Sala3.Ctg = 2;
            //Sala3.CalculerSalaire();



            /*******************************************************************************************************/
            /* Instanciation via constructeur*/


            

            try
            {

                Salarie Sal1 = new Salarie("Kévin", -14500.00, 2, 4);
                Salarie Sal2 = new Salarie("Josiane", 4523.00, 5, 3);
                Salarie Sal3 = new Salarie("Jo le gars", 2154.00, 87, 5);
                Salarie Sal4 = new Salarie("Jean-Eudes", -45812.00, 3, 12);
                Salarie Com1 = new Commercial("SteeEeeve", 17500, 5, 7, 5, 80000);
                Commercial Com2 = new Commercial("Georgette", 25100, 5, 7, 6, 80000);


                Sal1.CalculerSalaire();
                //double vraiSalaire = Sal1.salaireAbsolu(-14500.00);
                Sal1.AfficherMatricule();

                Sal2.CalculerSalaire();
                Sal2.AfficherMatricule();

                Sal3.CalculerSalaire();
                Sal3.AfficherMatricule();

                Sal4.CalculerSalaire();
                Sal4.AfficherMatricule();

                Com1.CalculerSalaire();
                Com1.AfficherMatricule();

                Com2.CalculerSalaire();
                Com2.AfficherMatricule();
                Console.WriteLine("------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("nombre de salariés : {0}", Salarie.count);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();

            }
            catch (SalarieException se)
            {
                Console.WriteLine("Catégories admises : \n[1] Cadre \n[2] Technicien \n[3] Employé");
                
            }

            



            /***********Essai liste*************/
            //Salarie[] listSalarie = new Salarie[3];
            //listSalarie[0] = new Salarie("Jean-Eudes", 45812.00, 3, 12);
            //listSalarie[1] = new Commercial("Georgette", 25100, 5, 7, 6, 80000);
            //listSalarie[2] = new Salarie("Jean-Eudes", 45812.00, 3, 12);
            //foreach (var item in listSalarie)
            //{
            //    item.CalculerSalaire();
            //    item.AfficherMatricule();
            //}


           

            //Console.WriteLine(Sal1);

            

        }   
            


        
    }
}
