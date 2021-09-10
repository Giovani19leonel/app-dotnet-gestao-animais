using System;
namespace Controle_de_Animais
{
    public static class Peixe
    {
         static int ç=-1, c=-1;
       public static string [] cores = new string[5];
       public static string [] especies = new string [5];
        public static string pele()
         {
             string cor;
             cor=Console.ReadLine();
             if (ç<5)
            {
                ç++;
                cores[ç]=cor;
            } 
             return(cores[ç]);
             
        }
        public static string especie()
        {
            string especiess;
            especiess=Console.ReadLine();
            if (c<5)
            {
                c++;
                especies[c]=especiess;
            } 
            return(especies[c]);
        } 
    }
}