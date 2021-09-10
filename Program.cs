using System;

namespace Controle_de_Animais
/*Crie um algoritmo/programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação.
 O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e peixes foram informados.
Regras que deverão ser seguidas para a implementação do algoritmo:
Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa deverá definir o tipo do animal como Peixe.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
*/
{
    class Program
    {
        
        static string [] nomes = new string[5];
        static string [] tipos = new string[5];
         public static int i=0, p=0, a=0, b=0, c=0, d=0,e=0,f=0, contador=0;
         public static string nome;
         public static string tipo;
        static void Main(string[] args)
        {
            System.Console.WriteLine("Seja bem vindo ao Programa de Controle de Animais!");
            System.Console.WriteLine("\nTipos aceitos: (gato), (cachorro), (peixe)");
            while(i<5){
                Console.WriteLine("\n{0} - Informe o nome e o tipo do seu animal:",i+1);
                Funcao.nome();
                Funcao.tipo();
            
            if(tipo=="cachorro")
            {
                Console.WriteLine("\n{0} - Informe a cor e a especie:",i);
                Cachorro.pele();
                Cachorro.especie();
            }
            if(tipo=="gato")
            {   
                Console.WriteLine("\n{0} - Informe a cor e a especie:",i);
                Gato.pele();
                Gato.especie();
            }
            if(tipo=="peixe")
            {
                Console.WriteLine("\n{0} - Informe a cor e a especie:",i);
                Peixe.pele();
                Peixe.especie();
            }
            }
            System.Console.WriteLine("\nDeseja visualizar o que foi armazenado? 1-sim 2-não");
            int resposta; resposta=int.Parse(Console.ReadLine());
            if (resposta==1)
            {
            for(Program.contador=0; Program.contador<5; Program.contador++)
            {
                Funcao.impressao();
            }
            }
            System.Console.WriteLine("\nTotal de Animais:");
            System.Console.WriteLine("\nCachorros:"+f+ "\n\nGatos:" +e+ "\n\nPeixes:"+d);
            System.Console.WriteLine("\nObrigado por utilizar o Programa!!!");
        }
        static public class Funcao
    {
        static public string nome()
        {
            Program.nome = Console.ReadLine();
            Program.nomes[Program.i] = Program.nome;
            Program.i++;
            return (Program.nome);
       }
       static public string tipo()
       {
           Program.tipo = Console.ReadLine();
           Program.tipos[Program.p] = Program.tipo;
           Program.p++;
           return (Program.tipo);
       }
       static public void impressao()
       {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{0} -", contador+1);
            Console.WriteLine("nome:{0}, tipo:{1}, ", Program.nomes[contador], Program.tipos[contador]);
            if (Program.tipos[contador]=="peixe"){
                Console.WriteLine("cor: {0}, especie: {1}", Peixe.cores[d], Peixe.especies[d]);
                d++;
            }
            if (Program.tipos[contador]=="gato"){
                Console.WriteLine("cor: {0}, especie: {1}", Gato.cores[e], Gato.especies[e]);
                e++;
            }
            if (Program.tipos[contador]=="cachorro"){
                Console.WriteLine("cor: {0}, especie: {1}", Cachorro.cores[f], Cachorro.especies[f]);
                f++;
            }
       }
       }
}
}