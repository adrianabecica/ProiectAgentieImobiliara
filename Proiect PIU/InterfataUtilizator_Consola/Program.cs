using System;
using System.Collections;
using LibrarieAgentie;
using NivelAccesDate;

namespace Agentie_Imobiliara
{
    class Program
    {


        static void Main(string[] args)
        {
            ArrayList imobiliare, beneficiari;

            //variabila de tip interfata 'IStocareData' care este initializata 
            //cu o instanta a clasei 'AdministrareImobiliare_FisierText' sau o instanta a clasei 'AdministrareImobiliare_FisierBinar' in functie de setarea 'FormatSalvare' din fisierul AppConfig
            IStocareData adminImobiliare = StocareFactory.GetAdministratorStocare();

           // imobiliare = adminImobiliare.GetImobiliare();
           // int nrImobiliare = imobiliare.Count;
           // Imobiliar.IdUltimImobiliar = nrImobiliare;
            //variabila de tip interfata 'IStocareData_Beneficiar' care este initializata 
            //cu o instanta a clasei 'AdministrareBeneficiari_FisierText' sau o instanta a clasei 'AdministrareBeneficiari_FisierBinar' in functie de setarea 'FormatSalvare_b' din fisierul AppConfig

            IStocareData_Beneficiar adminBeneficiari = StocareFactory.GetAdministratorStocareBeneficiar();

            beneficiari = adminBeneficiari.GetBeneficiari();
            int nrBeneficiari = beneficiari.Count;
            Beneficiar.IdUltimBeneficiar = nrBeneficiari;

            string optiune;
            do
            {
                Console.WriteLine("1. Afisare imobiliare");
                Console.WriteLine("2. Creare si adaugare oferta imobiliar");
                Console.WriteLine("3. Afisare beneficiari");
                Console.WriteLine("4. Creare si adaugare beneficiar");
                Console.WriteLine("5. Gasire imobiliar");
                Console.WriteLine("6. Modificare pret oferta");
                Console.WriteLine("7. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "1":
                      //  AfisareImobiliare(imobiliare);
                        break;
                    case "2":
                      //  Imobiliar imobiliarTastatura = CitireImobiliarTastatura();
                      //  imobiliare.Add(imobiliarTastatura);
                        //adaugare imobiliar in fisier
                      //  adminImobiliare.AddImobiliar(imobiliarTastatura);
                        break;
                    case "3":
                       // AfisareBeneficiari(beneficiari);
                        break;
                    case "4":
                       // Beneficiar beneficiarTastatura = CitireBeneficiarTastatura();
                     //   beneficiari.Add(beneficiarTastatura);
                        //adaugare beneficiar in fisier
                     //   adminBeneficiari.AddBeneficiar(beneficiarTastatura);
                        break;
                    case "5":
                        //string tip, strada, bloc, scara;
                        //int suprafata, nr, nr_apartament, pret;
                        //Imobiliar raspuns;

                        //Console.WriteLine("Introduceti tipul ofertei cautate:");
                        //tip = Console.ReadLine();
                        //Console.WriteLine("Introduceti suprafta ofertei cautate:");
                        //suprafata = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("Introduceti strada ofertei cautate:");
                        //strada = Console.ReadLine();
                        //Console.WriteLine("Introduceti nr ofertei cautate:");
                        //nr = Convert.ToInt32(Console.ReadLine());

                        //Console.WriteLine("Introduceti blocul ofertei cautate:");
                        //bloc = Console.ReadLine();

                        //Console.WriteLine("Introduceti scara ofertei cautate:");
                        //scara = Console.ReadLine();
                        //Console.WriteLine("Introduceti nr apartament ofertei cautate:");
                        //nr_apartament = Convert.ToInt32(Console.ReadLine());

                        //Console.WriteLine("Introduceti pretul ofertei cautate:");
                        //pret = Convert.ToInt32(Console.ReadLine());

                        //raspuns = adminImobiliare.GetImobiliar(tip, suprafata, strada, nr, bloc, scara, nr_apartament, pret);

                        //if (raspuns != null)
                        //    Console.WriteLine(raspuns.ConversieLaSir_PentruAfisare());
                        //else
                        //    Console.WriteLine("Oferta nu a fost gasita");
                        break;
                    case "6":

                        //AfisareImobiliare(imobiliare);
                       // Console.WriteLine("Introduceti  oferta a carei pret doriti sa-l modificati:");


                      //  Imobiliar ImobiliarActualizat = CitireImobiliarTastatura();
                      //  bool confirmare;
                      //  confirmare = adminImobiliare.UpdateImobiliar(ImobiliarActualizat);

                      //  if (confirmare)
                      //  {
                           // imobiliare = adminImobiliare.GetImobiliare();
                       //     AfisareImobiliare(imobiliare);
                     //   }
                       // else
                          //  Console.WriteLine("Fisierul nu a putut fi actualizat deoarece oferta introdusa nu este existenta!");
                        break;
                    case "7":
                        return;
                        break;
                    default:
                      //  Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "7");

            Console.ReadKey();
        }
        public static void AfisareImobiliare(ArrayList imobiliare)
        {
            Console.WriteLine("Imobiliarele sunt:");
            for (int i = 0; i < imobiliare.Count; i++)
            {
                Console.WriteLine(((Imobiliar)imobiliare[i]).ConversieLaSir_PentruAfisare());
            }
        }
        public static Imobiliar CitireImobiliarTastatura()
        {
            Console.WriteLine("Introduceti tip");
            string tip = Console.ReadLine();

            Console.WriteLine("Introduceti suprafata");
            int suprafata = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti strada");
            string strada = Console.ReadLine();

            Console.WriteLine("Introduceti nr");
            int nr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti bloc");
            string bloc = Console.ReadLine();

            Console.WriteLine("Introduceti scara");
            string scara = Console.ReadLine();

            Console.WriteLine("Introduceti nr_apartament");
            int nr_apartament = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti pret");
            int pret = Convert.ToInt32(Console.ReadLine());

            Imobiliar s = new Imobiliar(tip, suprafata, strada, nr, bloc, scara, nr_apartament, pret);

            Console.WriteLine("Alegeti grad finisare la: ");
            Console.WriteLine("1 - Rosu \n" +
            "2 - Gri \n" +
            "3 - Alb \n" +
            "4 - Cheie \n");
            //int ok = 0;
            //do
            //{
            //    int optiune = Convert.ToInt32(Console.ReadLine());
            //    if (optiune >= 1 && optiune <= 4)
            //    {
            //        s.Grad = (Gradfinisare)optiune;
            //        ok = 1;
            //    }
            //    else
            //        Console.WriteLine("Ocupatia introdusa nu corespunde celor disponibile");
            //} while (ok == 0);

            Gradfinisare p = Gradfinisare.Alb | Gradfinisare.Gri | Gradfinisare.Rosu;
            s.Grad = p;


            return s;
        }

        public static void AfisareBeneficiari(ArrayList beneficiari)
        {
            Console.WriteLine("Beneficiarii sunt:");
            for (int i = 0; i < beneficiari.Count; i++)
            {
                Console.WriteLine(((Beneficiar)beneficiari[i]).ConversieLaSir_PentruAfisare());
            }
        }
        public static Beneficiar CitireBeneficiarTastatura()
        {
            Console.WriteLine("Introduceti nume");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenume");
            string prenume = Console.ReadLine();

            Console.WriteLine("Introduceti cnp");
            int cnp = Convert.ToInt32(Console.ReadLine());
            Beneficiar b = new Beneficiar(nume, prenume, cnp);

            Console.WriteLine("Alegeti un ocupatia: ");
            Console.WriteLine("1 - Angajat \n" +
            "2 - Somer \n" +
            "3 - Pensionar \n" +
            "4 - Casnic \n");
            int ok = 0;
            do
            {
                int optiune = Convert.ToInt32(Console.ReadLine());
                if (optiune >= 1 && optiune <= 4)
                {
                    b.Ocupatie = (OcupatieBeneficiar)optiune;
                    ok = 1;
                }
                else
                    Console.WriteLine("Ocupatia introdusa nu corespunde celor disponibile");
            } while (ok == 0);

            return b;
        }
    }

}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Agentie_Imobiliara
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}
