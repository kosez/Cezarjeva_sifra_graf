using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cezarjeva_sifra
{
    public class Desifriranje:Tabela
    {
        public string text;
        public int shift;
        public int stCrk;
        public string rezultat;
        public void decrypt(string text, int shift)
        {
            rezultat = "";
            this.text = text;
            this.shift = shift;
            this.text = text.ToUpper();          //spremenim besedilo v velike začetnnice
            stCrk = text.Length;                //preštejem številko simbolov v besedilu
            char[] crke = this.text.ToCharArray();   //postavitev funkcije za stetje



                

                for (int i = 0; i < stCrk; i++)
                {
                    int l = 0;
                    while (true)                      //primerjanje črk in izpis če je prav SAMO TEST
                    {


                        if (crke[i] == abeceda[l])                      //primerja vneseno črko z črko v tebeli abeceda
                        {

                            if ((l - shift) < 0)        //če je seštevek črke in preika večji od dolžine tabele gre znova, k začetni črki
                            {
                                rezultat+=abeceda[((abeceda.Length) + (l - shift))];                //izpiše številko črke z zamiko 
                            }
                            else
                            {
                                rezultat+=abeceda[l - shift];          //izpiši številko črke z zamikom
                            }
                            break;

                        }
                        l++;                   // poveča l za 1. Za premik črke v tabeli
                    }


                }
            }
        }
    }

