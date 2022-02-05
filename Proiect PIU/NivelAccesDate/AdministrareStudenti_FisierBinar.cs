using LibrarieModele;
using System;
using System.Collections;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareStudenti_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareStudenti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddStudent(Student s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public ArrayList GetStudenti()
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }
    }
}
