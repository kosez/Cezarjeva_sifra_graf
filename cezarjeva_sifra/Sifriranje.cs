using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cezarjeva_sifra
{
    public class Sifriranje:Tabela
    {
        
        public int shift;       //zamik črk
        public string text;     //besedilo, ki ga hočemo šifrirati
        public int stCrk;       //dolžina besedila
        public string rezultat;
        public void encryption(string text, int shift)       //ustvaril metodo za izvanje šifriranje
            {
                rezultat = "";
                this.text = text;                       
                this.shift = shift;
                this.text = text.ToUpper();             //spremenim besedilo v velike začetnnice
                stCrk = text.Length;                    //preštejem številko simbolov v besedilu
                char[] crke = this.text.ToCharArray();   

                

                for (int i = 0; i < stCrk; i++)
                {
                    int l = 0;
                    while (true)                      //primerjanje črk in izpis če je prav SAMO TEST
                    {


                        if (crke[i] == abeceda[l])                      //primerja vneseno črko z črko v tebeli abeceda
                        {


                            if ((l + shift) >= (abeceda.Length))        //če je seštevek črke in preika večji od dolžine tabele gre znova, k začetni črki
                            {


                            rezultat += (abeceda[(l + shift) % abeceda.Length]);                //izpiše številko črke z zamiko 


                            }
                            else
                            {
                            rezultat += abeceda[l + shift];          //izpiši številko črke z zamikom
                            }
                            break;

                        }
                        l++;                   // poveča l za 1. Za premik črke v tabeli
                    }

                }

            }
        }
    }




