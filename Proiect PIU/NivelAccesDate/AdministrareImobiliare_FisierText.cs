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
    //clasa AdministrareImobiliare_FisierText implementeaza interfata IStocareData
    public class AdministrareImobiliare_FisierText : IStocareData
    {
        string NumeFisier { get; set; }

        public AdministrareImobiliare_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddImobiliar(Imobiliar s)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(s.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                //throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

       

        public Imobiliar GetImobiliar(string tip, int suprafata, string strada, int nr, string bloc, string scara, int nr_apartament, int pret)
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                
                string line;
                //citeste cate o linie din fisier si
                //creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Imobiliar s = new Imobiliar(line);
                    if(s.Tip==tip && s.Suprafata==suprafata && s.Strada==strada && s.Nr==nr && s.Bloc==bloc && s.Scara==scara && s.Nr_apartament==nr_apartament && s.Pret==pret)
                    {
                        //string raspuns = s.ConversieLaSir_PentruAfisare();
                        //Console.WriteLine(raspuns);
                        return s;
                       
                    }
                }
               
                    return null;
            }
        }

        public Imobiliar GetImobiliar(int idImobiliar )
        {


            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Imobiliar imobiliare = new Imobiliar(line);
                    if (imobiliare.IdImobiliar == idImobiliar)
                        return imobiliare;
                }
            }

            return null;
        }
     

        public bool UpdateImobiliar(Imobiliar ImobiliarActualizat)
        {
            List<Imobiliar> imobiliare = GetImobiliare();

            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Imobiliar i in imobiliare)
                    {
                        Imobiliar imobiliarPentruScrisInFisier = i;
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (i.IdImobiliar == ImobiliarActualizat.IdImobiliar)
                        {
                            imobiliarPentruScrisInFisier = ImobiliarActualizat;
                        }
                        swFisierText.WriteLine(imobiliarPentruScrisInFisier.ConversieLaSir_PentruScriereInFisier());
                    }
                    actualizareCuSucces = true;
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

            return actualizareCuSucces;

        }

        public List<Imobiliar> GetImobiliare()
        {
            List<Imobiliar> imobiliare = new List<Imobiliar>();
            
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Imobiliar imobiliarDinFisier = new Imobiliar(line);
                        imobiliare.Add(imobiliarDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                //throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return imobiliare;
        }
    }
}
