using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP1
{
    class Commercial : Salarie
    {
       
        private double chiffreAffaire;
        private double commission;


        /*************************************/
        /*           CONSTRUCTEUR            */
        /*************************************/


            /// <summary>
            /// Appel constructeur classe mère
            /// </summary>
            /// <param name="NomSalarie"></param>
            /// <param name="Salaire"></param>
            /// <param name="Matricule"></param>
            /// <param name="Serv"></param>
            /// <param name="Ctg"></param>
        public  Commercial (string NomSalarie, double Salaire, int Serv, int Ctg, int LaComm, double LeCA):base(NomSalarie, Salaire,Serv, Ctg)
            {
                 commission = LaComm;
                 chiffreAffaire = LeCA;
                
            }


        /*************************************/
        /*              METHODES             */
        /*************************************/

        /// <summary>
        /// Calcul salaire Commercial ( fixe+commission )
        /// </summary>
        public override void CalculerSalaire() /*en virtual dans classe Mère Salarie*/
        {
            commission = 0.05;
            Salaire = Salaire + commission*chiffreAffaire;
           Console.WriteLine("le salaire de " + NomSalarie + " est de " + Salaire + " Euros.");

        }
        

    }
}