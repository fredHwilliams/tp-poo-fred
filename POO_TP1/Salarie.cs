using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP1
{
    public class Salarie : Personne
    {


        /*********************************************/
        /*              ATTRIBUTS                    */
        /**********************************************/

        private int matricule;
        private int categorie;
        private int service;
        private string nom;
        private double salaire;

        private static int countMat=0; /*incrémentation du matricule à la création de chaque nouvel objet - cf.constructeur*/
    

        /// <summary>
        /// Compteur
        /// </summary>
        static public int count;


        /**********************************************/
        /*                METHODES                    */
        /**********************************************/

        public double salaireAbsolu(double salaire)
        {

            if (salaire < 0)
            {
                return Math.Abs(salaire);
            }
            else
            {
                return salaire;
            }

        }

        /// <summary>
        /// retourne la valeur salaire
        /// </summary>
        public virtual void CalculerSalaire() /*VIRTUAL Override dans classe dérivée Commercial*/
        {
            Console.WriteLine("le salaire de "+nom+" est de " +salaire+" Euros.");
        }

        /// <summary>
        /// Afficher matricule incrémenté
        /// </summary>
        public void AfficherMatricule()
        {
            Console.WriteLine("Matricule :"+matricule+" .");
        }

        /// <summary>
        /// Méthode EQUALS - compare 2 objets
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Salarie s = obj as Salarie;
            if (s == null)
            {
                return false;
            }
            return NomSalarie == s.NomSalarie && Matricule == s.Matricule; 
        }

        /// <summary>
        /// Méthode ToString 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return this.nom + "," + this.salaire + "," + this.matricule + "," + this.service + "," + this.categorie + ",";
            return "Salarié :" + NomSalarie + "," + Salaire + "," + Matricule + "," + Serv + "," + Ctg + ".";
        }

        /* implémente direct une méthode à la création d'un nouvel objet*/
        /// <summary>
        ///Compteur
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="catg"></param>
        /// <param name="serv"></param>
        /// <param name="nomSal"></param>
        /// <param name="salai"></param>
        
        public Salarie()
        {
            ++count;

        }


        /// <summary>
        /// ACCESSEURS GET/SET
        /// </summary>
        /// <returns></returns>
        public int Matricule                       /*utilisation des accesseurs car attributs private*/
        {
            get; set;
        }                  
        
        /// <summary>
        /// GET/SET - autre écriture
        /// </summary>
        public int Ctg
        {
            get
            {
                return this.categorie;
            }
            set
            {
                if (Ctg<1 || Ctg>3)
                {
                    SalarieException se = new SalarieException(this);
                    throw se;
                }
                categorie = value;
            }
        }

        public int Serv
        {
            get
            {
                return this.service;
            }
            set
            {
                service = value;
            }
        }
        public string NomSalarie
        {
            get
            {
                return this.nom;
            }
            set
            {
                nom = value;
            }
        }
         public double Salaire
        {
            get
            {
                return this.salaire;
            }
            set
            {
                salaire = value;

            }
        }


        /*********************************************/
        /*             CONSTRUCTEUR                  */
        /*********************************************/





        /// <summary>
        /// Paramètres d'entrée attributs nouveau Salarié
        /// </summary>
        /// <param name="NomSalarie"></param>
        /// <param name="Salaire"></param>
        /// <param name="Matricule"></param>
        /// <param name="Serv"></param>
        /// <param name="Ctg"></param>
        public Salarie(string NomSalarie, double Salaire,/*int Matricule, */int Serv, int tg)
        {
            nom = NomSalarie;

            salaire = Salaire;
            //if (salaire <= 0)
            //{
            //    salaire=  Math.Abs(salaire);
            //}
            //else
            //{
            //     Salaire =salaire;
            //}
            

            service = Serv;
            this.Ctg = Ctg;
            ++count;  /*penser à ajouter le compteur*/
            matricule = ++countMat; /*immatriculation du salarié suivant - cf. att + méthodes*/


        }

        /******************************************/
        /*           DESTRUCTEUR                  */
        /******************************************/



        /*On le cache, ça marche mais c'est moche*/
        //~Salarie()
        //{
        //    Salarie.count--;
        //    Console.WriteLine("Nouveau compte salariés : {0}", count);
        //}

    }
}
