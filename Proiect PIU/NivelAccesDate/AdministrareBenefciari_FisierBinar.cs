using LibrarieAgentie;
using System;
using System.Collections;

namespace NivelAccesDate
{
    //clasa AdministrareBeneficiari_FisierBinar implementeaza interfata IStocareData_Beneficiar
    public class AdministrareBeneficiari_FisierBinar : IStocareData_Beneficiar
    {
        string NumeFisier_b { get; set; }
        public AdministrareBeneficiari_FisierBinar(string numeFisiser_b)
        {
            this.NumeFisier_b = NumeFisier_b;
        }

        public void AddBeneficiar(Beneficiar b)
        {
            throw new Exception("Optiunea AddBeneficiar nu este implementata");
        }

        public ArrayList GetBeneficiari()
        {
            throw new Exception("Optiunea GetBeneficiari nu este implementata");
        }

        
    }

}
