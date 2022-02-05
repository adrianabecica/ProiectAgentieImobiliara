using System;

namespace LibrarieAgentie
{
    public class Beneficiar
    {
        //constante
    
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';


        private const int ID_BENEFICIAR = 0;
        private const int NUME= 1;
        private const int PRENUME = 2;
        private const int CNP = 3;
        private const int OCUPATIE = 4;
        //proprietati auto-implemented
        public static int IdUltimBeneficiar { get; set; } = 0;
        public int IdBeneficiar { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
       
        public int Cnp { get; set; }

        public OcupatieBeneficiar Ocupatie{ get; set; }


        #region _Constructori_
        //contructor implicit
        public Beneficiar()
        {
            Nume = string.Empty;
           Prenume = string.Empty;
            Cnp = 0;
            IdUltimBeneficiar++;
            IdBeneficiar = IdUltimBeneficiar;
        }

        //constructor1 cu parametri
        public Beneficiar(string _nume, string _prenume, int _cnp)
        {
            Nume = _nume;
            Prenume = _prenume;
            Cnp = _cnp;
            IdUltimBeneficiar++;
            IdBeneficiar = IdUltimBeneficiar;

        }



        //constructor3 cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Beneficiar(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            IdBeneficiar = Convert.ToInt32(dateFisier[ID_BENEFICIAR]);
            Nume = dateFisier[NUME];
            Prenume= dateFisier[PRENUME];
            Cnp = Convert.ToInt32(dateFisier[CNP]);
            Ocupatie= (OcupatieBeneficiar)Convert.ToInt32(dateFisier[OCUPATIE]);
            IdUltimBeneficiar++;
            IdUltimBeneficiar = IdBeneficiar;

        }

        #endregion



        public string ConversieLaSir_PentruAfisare()
        {

            string b = $"\nBeneficiarul este:\n\tnume: {Nume} \n\tPrenume:  {Prenume} \n\tCnp {Cnp}\n\tOcupatie {Ocupatie}";
            return b;

        }

        public string ConversieLaSir_PentruScriereInFisier()
        {

            string b = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER, IdBeneficiar.ToString(), Nume, Prenume, Cnp.ToString(),Ocupatie) ;

            return b;
        }

    
    }
}
