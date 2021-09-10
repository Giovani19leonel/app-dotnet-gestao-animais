  
using System;
namespace Controle_de_Animais
{
    public static class Gato
    {
        static int t=-1, z=-1;
       public static string [] cores = new string[5];
       public static string [] especies = new string [5];
        public static string pele()
         {
             string cor;
             cor=Console.ReadLine();
             if (t<5)
            {
                t++;
                cores[t]=cor;
            } 
             return(cores[t]);
        }
        public static string especie()
        {
            string especiess;
            especiess=Console.ReadLine();
            if (z<5)
            {
                z++;
                especies[z]=especiess;
            } 
            return(especies[z]);
        } 
    }
}