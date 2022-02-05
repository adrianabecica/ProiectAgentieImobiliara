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
    //definitia interfetei
    public interface IStocareData
    {
        void AddImobiliar(Imobiliar s);
        Imobiliar GetImobiliar(string tip, int suprafata, string strada, int nr, string bloc, string scara, int nr_apartament, int pret);
        Imobiliar GetImobiliar(int idImobiliar);
        bool UpdateImobiliar(Imobiliar ImobiliarActualizat);
        List<Imobiliar> GetImobiliare();
    }
}
