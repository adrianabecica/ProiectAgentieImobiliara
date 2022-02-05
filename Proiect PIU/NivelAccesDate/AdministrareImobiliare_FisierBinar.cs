using LibrarieAgentie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace NivelAccesDate
{
    //clasa AdministrareImobiliare_FisierBinar implementeaza interfata IStocareData
    public class AdministrareImobiliare_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareImobiliare_FisierBinar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();
        }

            public void AddImobiliar(Imobiliar s)
        {
            throw new Exception("Optiunea AddImobiliar nu este implementata");
        }

        public List<Imobiliar> GetImobiliare()
        {
            throw new Exception("Optiunea GetImobiliare nu este implementata");
        }

        public Imobiliar GetImobiliar(string tip, int suprafata, string strada, int nr, string bloc, string scara, int nr_apartament, int pret)
        {
            throw new Exception("Optiunea GetImobiliar nu este implementata");
        }
        public Imobiliar GetImobiliar( int idImobiliar)
        {
            throw new Exception("Optiunea GetImobiliar nu este implementata");
        }

        public bool UpdateImobiliar(Imobiliar ImobiliarActualizat)
        {
            throw new Exception("Optiunea UpdateImobiliar nu este implementata");
        }
    }
    
}
