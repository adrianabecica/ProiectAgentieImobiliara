using System;
using System.Collections.Generic;
using System.Collections;
namespace LibrarieAgentie
{
    public class Imobiliar
    {
        //constante
      
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';


        private const int ID_IMOBILIAR = 0;
        private const int TIP = 1;
        private const int SUPRAFATA = 2;
        private const int STRADA = 3;
        private const int NR = 4;
        private const int BLOC = 5;
        private const int SCARA = 6;
        private const int NR_APARTAMENT = 7;
        private const int PRET = 8;
        private const int GRAD = 9;
        private const int UTILITATI = 10;
        private const int COMPARTIMENTARE = 11;

        //proprietati auto-implemented
        public DateTime dataConstructie { get; set; }
       
        public static int IdUltimImobiliar { get; set; } = 0;
        public int IdImobiliar { get; set; }
        public string Tip { get; set; }
        public int Suprafata { get; set; }
        public string Strada { get; set; }
        public int Nr { get; set; }
        public string Bloc { get; set; }
        public string Scara { get; set; }
        public int Nr_apartament { get; set; }
        public int Pret { get; set; }
        public Gradfinisare Grad { get; set; }

       

       



        #region _Constructori_
        //contructor implicit
        public Imobiliar()
        {
            Tip = string.Empty;
            Suprafata = 0;
            Strada = string.Empty;
            Nr = 0;
            Bloc = string.Empty;
            Scara = string.Empty;
            Nr_apartament = 0;
            Pret = 0;
           
            IdUltimImobiliar++;
            IdImobiliar = IdUltimImobiliar;
        }

        //constructor1 cu parametri
        public Imobiliar(string _tip, int _suprafata, string _strada, int _nr, string _bloc, string _scara, int _nr_apartament, int _pret)
        {
            Tip = _tip;
            Suprafata = _suprafata;
            Strada = _strada;
            Nr = _nr;
            Bloc = _bloc;
            Scara = _scara;
            Nr_apartament = _nr_apartament;
            Pret = _pret;
          
            IdUltimImobiliar++;
            IdImobiliar = IdUltimImobiliar;
        }



        //constructor3 cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Imobiliar(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            IdImobiliar = Convert.ToInt32(dateFisier[ID_IMOBILIAR]);
            Tip = dateFisier[TIP];
            Suprafata = Convert.ToInt32(dateFisier[SUPRAFATA]);
            Strada = dateFisier[STRADA];
            Nr = Convert.ToInt32(dateFisier[NR]);
            Bloc = dateFisier[BLOC];
            Scara = dateFisier[SCARA];
            Nr_apartament = Convert.ToInt32(dateFisier[NR_APARTAMENT]);
            Pret = Convert.ToInt32(dateFisier[PRET]);
           // Grad = (Gradfinisare)Convert.ToInt32(dateFisier[GRAD]);
            Grad = (Gradfinisare)Enum.Parse(typeof(Gradfinisare), dateFisier[GRAD]);
         
            IdUltimImobiliar++;
            IdUltimImobiliar = IdImobiliar;
            
        }

        #endregion


      
        public string ConversieLaSir_PentruAfisare()
        {
          
                string s = $"\nOferta este:\n\t{Tip} \n\tsuprafata de  {Suprafata} metri patrati\n\tstrada {Strada}\n\tnumarul  {Nr}\n\tbloc {Bloc}\n\tscara {Scara}\n\tnumar apartament {Nr_apartament}\n\tpretul de  {Pret} de euro\n\t grad de finisare {Grad}";
                return s;
            
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            
            
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}",
                SEPARATOR_PRINCIPAL_FISIER, IdImobiliar.ToString(), Tip, Suprafata, Strada, Nr, Bloc, Scara, Nr_apartament, Pret,Grad);

            return s;
        }
        public static string Comparare(Imobiliar i1, Imobiliar i2)
        {
            if (i1.Pret > i2.Pret)
                return $"Oferta pentru {i1.Tip} are pretul mai mare";
            else
                return $"Oferta pentru {i2.Tip} are pretul mai mare";
        }

    }
}
