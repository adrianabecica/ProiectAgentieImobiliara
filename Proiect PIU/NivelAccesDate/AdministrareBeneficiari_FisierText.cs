using LibrarieAgentie;
using System;
using System.Collections;
using System.IO;

namespace NivelAccesDate
{
    //clasa AdministrareBeneficiari_FisierText implementeaza interfata IStocareData_Beneficiar
    public class AdministrareBeneficiari_FisierText : IStocareData_Beneficiar
    {
        string NumeFisier_b { get; set; }

        public AdministrareBeneficiari_FisierText(string numeFisier_b)
        {
            this.NumeFisier_b = numeFisier_b;
            Stream sFisierText = File.Open(numeFisier_b, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddBeneficiar(Beneficiar b)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier_b, true))
                {
                    swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }



      
        public ArrayList GetBeneficiari()
        {
            ArrayList beneficiari = new ArrayList();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier_b))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Beneficiar beneficiarDinFisier = new Beneficiar(line);
                        beneficiari.Add(beneficiarDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                // throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return beneficiari;
        }
    }
}
