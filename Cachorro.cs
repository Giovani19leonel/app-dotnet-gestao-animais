using System;
namespace Controle_de_Animais
{
    public static class Cachorro
    {
        static int u=-1, k=-1;
       public static string [] cores = new string[5];
       public static string [] especies = new string [5];
        public static string pele()
         {
             string cor;
             cor=Console.ReadLine();
             if (u<5)
            {
                u++;
                cores[u]=cor;
            } 
             return(cores[u]);
        }
        public static string especie()
        {
            string especiess;
            especiess=Console.ReadLine();
            if (k<5)
            {
                k++;
                especies[k]=especiess;
            } 
            return(especies[k]);
        } 
    }
}