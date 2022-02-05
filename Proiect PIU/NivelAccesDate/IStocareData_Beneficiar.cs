using LibrarieAgentie;
using System.Collections;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData_Beneficiar
    {
        void AddBeneficiar(Beneficiar b);
      
        
        ArrayList GetBeneficiari();
    }
}
