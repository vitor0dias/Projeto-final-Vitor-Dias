using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projeto_final_Vitor_Dias.model
{
    internal class Elevador
    {
        private static System.Timers.Timer aTimer;
        
        static void Main(string[] args)
        { int pom = 1;
            int com = 0;
            int sas = 0;
            int decand = 0;
            int suband = 0;
            int retpess = 0;
            int numepess = 0;
            int exit = 0;
            int capess = 0;
            int numpess = 0;
            int andpre = 0;
            string comandos;
            string comandos2;
            int andamo = 0;
            string andamo2 = "Terreo";
            string Nome = "usuario";
            Console.WriteLine("- Ola!!!");
            Thread.Sleep(1000);
            Console.WriteLine($"- Qual é seu nome");
            Nome = Console.ReadLine();
            while (pom == 1)
            {

                string menu = ($"\n {Nome} os comandos basicos são:\n " +
                    "\n- {A}Inicializar ==== inicia o programa" +
                    "\n- {B}Entrar      ==== adiciona uma pessoa ao elevador" +
                    "\n- {C}Sair        ==== retira uma passoa do elevador" +
                    "\n- {D}Subir       ==== sobe um ardar " +
                    "\n- {E}Decer       ==== dece um andar \n" +
                    "\n- Lembrando que para começar o programa, " +
                    "o comando inicializar devem ser acionado!!!\n " +
                    $"\n- {Nome} Caso queria começar digite Inicializar ou A:");

                string menu2 = ($"\n {Nome} os comandos basicos são: " +
                   "\n{A}Entrar ==== adiciona uma pessoa ao elevador" +
                   "\n{B}Sair   ==== retira uma passoa do elevador" +
                   "\n{C}Subir  ==== sobe para o ardar " +
                   "\n{D}Decer  ==== dece para o  andar " +
                   $"\n {Nome} Execute o primeiro passo do elevador\n\n O que voçe gostaria de fazer agora por exemplo" + "{A}Entrar,{B}Sair ");

                Console.Clear();
                Console.WriteLine(menu);
                comandos = Console.ReadLine();
                if (comandos == "A"
                    || comandos == "a"
                    || comandos == "Inicializar"
                    || comandos == "inicializar")
                {
                    com = 0;
                    while (com < 2)
                    {
                        Console.Clear();
                        Console.WriteLine($"\n - {Nome} informe quantos andares tem o Predio\n>");
                        andpre = int.Parse(Console.ReadLine());

                        if (andpre <= 1)
                        {
                            Console.WriteLine($" - {Nome} Porfavor o predio tem que ter mais de 2 andares se não ele é uma casa \n espere.... ");
                            Thread.Sleep(5000);
                        }
                        else
                        {
                            com = 3;
                        }
                    }
                    while (com < 4)
                    {
                        Console.Clear();
                        Console.WriteLine($"\n - {Nome} Qual vai ser a capacidade de pessoas no  elevador \n>");
                        capess = int.Parse(Console.ReadLine());
                        if (capess <= 0)
                        {
                            Console.WriteLine($" - {Nome} Por favor acapacidade tem que ser maior que duas pessoas no  elevador \n espere.... ");
                            Thread.Sleep(5000);
                        }
                        else
                        {
                            com = 5;
                        }
                    }
                    while (com < 6)
                    {
                        Console.Clear();
                        Console.WriteLine($"\n - {Nome} Quantas Pessoas vão entrar no elevador \n> ");

                        numpess = int.Parse(Console.ReadLine());
                        if (numpess <= 0)
                        {
                            Console.WriteLine($" - {Nome} Porfavor adicione mais de uma pessoa no elevador\n espere.... ");
                            Thread.Sleep(5000);
                            Console.Clear();
                        }
                        else if (numpess > capess)
                        {
                            Console.WriteLine($" - {Nome} Porfavor a quantidade de pessoas  no elevador nao pode ser maior que a capacidade  maxima \n espere....");
                            Thread.Sleep(7000);
                            Console.Clear();
                        }
                        else
                        {
                            pom = 2;
                            com = 7;
                        }
                    }
                    while (exit == 0)
                    {
                        Console.Clear();

                        if(andamo == andpre)
                        {
                            Console.Clear();
                            andamo2 = "Cobertura";
                            Console.WriteLine($"- Numero de andares: {andpre}\n- Capacidade maxima: {capess}\n- Numero de pessoas dentro do elevador no momento: {numpess}\n- Andar atual: {andamo2}\n" + menu2 + " caso queira sair digite Cancelar ");
                            comandos2 = Console.ReadLine();
                            if (
                               comandos2 == "B"
                            || comandos2 == "b"
                            || comandos2 == "Sair"
                            || comandos2 == "sair")
                            {
                                if (numpess <= 0)
                                {
                                    Console.WriteLine($"\n Não á pessoas para retirar  no elevador \n espere....  ");
                                    Thread.Sleep(5000);
                                    Console.Clear();
                                }
                                Console.WriteLine($"\nQuantas pessoas serão retiradas? ");
                                retpess = int.Parse(Console.ReadLine());
                                if (retpess > numpess)
                                {
                                    Console.WriteLine($"\n Não é possivel retirar mais pessoas que a quantidade  de pessoas no elevador \n espere....  ");
                                    Thread.Sleep(5000);
                                    Console.Clear();
                                }
                                else
                                {
                                    numpess = numpess - retpess;
                                    Console.Clear();
                                }

                            }


                            else if (
                             comandos2 == "A"
                          || comandos2 == "a"
                          || comandos2 == "Entrar"
                          || comandos2 == "entrar")
                            {
                                Console.WriteLine($"\n - Quantas pessoas serão adicionadas? ");
                                numepess = int.Parse(Console.ReadLine());
                                numepess = numepess + numpess;
                                if (numepess > capess)
                                {
                                    Console.WriteLine($"\nCapacidade maxima  do elevador atingida não é possivel adicionar mais pessoas \n espere....  ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {
                                    numpess = numepess + numpess;
                                    Console.Clear();
                                }



                            }

                            else if (
                            comandos2 == "C"
                         || comandos2 == "c"
                         || comandos2 == "Subir"
                         || comandos2 == "subir")
                            {
                                Console.WriteLine($"\n - Para qual andar o elevador ira subir ");
                                suband = int.Parse(Console.ReadLine());
                                if (suband > andpre)
                                {
                                    Console.WriteLine($"\n O elevador nao pode subir mais  do que  no o numero de andares determinados \n espere.... ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {
                                    andamo = suband;
                                    Console.Clear();
                                }
                            }

                            else if (
                            comandos2 == "D"
                         || comandos2 == "d"
                         || comandos2 == "Decer"
                         || comandos2 == "decer")
                            {
                                Console.WriteLine($"\n - Para qual andar o  elevador ira decer ");
                                decand = int.Parse(Console.ReadLine());
                                if (decand > andpre)
                                {
                                    Console.WriteLine($"\n O elevador nao pode decer mais  do que  no o numero de andares determinados \n espere....   ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {

                                    andamo = decand;
                                    Console.Clear();
                                }
                            }
                            else if (comandos2 == "cancelar"||comandos2 == "Cancelar")
                            {
                                exit = 1;
                                Console.WriteLine($"tado!!!!");
                            }
                            else
                            {
                                Console.WriteLine($"\n - {Nome}  Erro digite o solicitado!!!!");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                        if (andamo == 0)
                        {
                            Console.WriteLine($"- Numero de andares: {andpre}\n- Capacidade maxima: {capess}\n- Numero de pessoas dentro do elevador no momento: {numpess}\n- Andar atual: {andamo2}\n" + menu2 + " caso queira sair digite Cancelar ");
                            comandos2 = Console.ReadLine();
                            if (
                               comandos2 == "B"
                            || comandos2 == "b"
                            || comandos2 == "Sair"
                            || comandos2 == "sair")
                            {
                                if (numpess <= 0)
                                {
                                    Console.WriteLine($"\n Não á pessoas para retirar  no elevador \n espere....  ");
                                    Thread.Sleep(5000);
                                    Console.Clear();
                                }
                                Console.WriteLine($"\nQuantas pessoas serão retiradas? ");
                                retpess = int.Parse(Console.ReadLine());
                                if (retpess > numpess)
                                {
                                    Console.WriteLine($"\n Não é possivel retirar mais pessoas que a quantidade  de pessoas no elevador \n espere....  ");
                                    Thread.Sleep(5000);
                                    Console.Clear();
                                }
                                else
                                {
                                    numpess = numpess - retpess;
                                    Console.Clear();
                                }

                            }


                            else if (
                             comandos2 == "A"
                          || comandos2 == "a"
                          || comandos2 == "Entrar"
                          || comandos2 == "entrar")
                            {
                                Console.WriteLine($"\n - Quantas pessoas serão adicionadas? ");
                                numepess = int.Parse(Console.ReadLine());
                                numepess = numepess + numpess;
                                if (numepess > capess)
                                {
                                    Console.WriteLine($"\nCapacidade maxima  do elevador atingida não é possivel adicionar mais pessoas \n espere....  ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {
                                    numpess = numepess + numpess;

                                    Console.Clear();
                                }



                            }

                            else if (
                            comandos2 == "C"
                         || comandos2 == "c"
                         || comandos2 == "Subir"
                         || comandos2 == "subir")
                            {
                                Console.WriteLine($"\n - Para qual andar o elevador ira subir ");
                                suband = int.Parse(Console.ReadLine());
                                if (suband > andpre)
                                {
                                    Console.WriteLine($"\n O elevador nao pode subir mais  do que  no o numero de andares determinados \n espere.... ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {
                                    andamo = suband;
                                    Console.Clear();
                                }
                            }

                            else if (
                            comandos2 == "D"
                         || comandos2 == "d"
                         || comandos2 == "Decer"
                         || comandos2 == "decer")
                            {
                                Console.WriteLine($"\n - Para qual andar o  elevador ira decer ");
                                decand = int.Parse(Console.ReadLine());
                                if (decand > andpre)
                                {
                                    Console.WriteLine($"\n O elevador nao pode decer mais  do que  no o numero de andares determinados \n espere....   ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {

                                    andamo = decand;
                                    Console.Clear();
                                }
                            }

                            else if (
                                comandos2 == "Sair"
                                ||
                                comandos2 == "sair"
                                    )
                            {
                                sas++;
                                Console.Clear();
                            }
                            else if (comandos2 == "cancelar"||comandos2 == "Cancelar")
                            {
                                exit = 1;
                            }
                            else
                            {
                                Console.WriteLine($"\n - {Nome}  Erro digite o solicitado!!!!");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"- Numero de andares: {andpre}\n- Capacidade maxima: {capess}\n- Numero de pessoas dentro do elevador no momento: {numpess}\n- Andar atual: {andamo}\n" + menu2 + " caso queira sair digite Cacelar ");
                            comandos2 = Console.ReadLine();
                            if (
                               comandos2 == "B"
                            || comandos2 == "b"
                            || comandos2 == "Sair"
                            || comandos2 == "sair")
                            {
                                if (numpess <= 0)
                                {
                                    Console.WriteLine($"\n Não á pessoas para retirar  no elevador \n espere....  ");
                                    Thread.Sleep(5000);
                                    Console.Clear();
                                }
                                Console.WriteLine($"\nQuantas pessoas serão retiradas? ");
                                retpess = int.Parse(Console.ReadLine());
                                if (retpess > numpess)
                                {
                                    Console.WriteLine($"\n Não é possivel retirar mais pessoas que a quantidade  de pessoas no elevador \n espere....  ");
                                    Thread.Sleep(5000);
                                    Console.Clear();
                                }
                                else
                                {
                                    numpess = numpess - retpess;
                                    Console.Clear();
                                }

                            }


                            else if (
                             comandos2 == "A"
                          || comandos2 == "a"
                          || comandos2 == "Entrar"
                          || comandos2 == "entrar")
                            {
                                Console.WriteLine($"\n - Quantas pessoas serão adicionadas? ");
                                numepess = int.Parse(Console.ReadLine());
                                numepess = numepess + numpess;
                                if (numepess > capess)
                                {
                                    Console.WriteLine($"\nCapacidade maxima  do elevador atingida não é possivel adicionar mais pessoas \n espere....  ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {
                                    numpess = numepess + numpess;
                                    Console.Clear();
                                }



                            }

                            else if (
                            comandos2 == "C"
                         || comandos2 == "c"
                         || comandos2 == "Subir"
                         || comandos2 == "subir")
                            {
                                Console.WriteLine($"\n - Para qual andar o elevador ira subir ");
                                suband = int.Parse(Console.ReadLine());
                                if (suband > andpre)
                                {
                                    Console.WriteLine($"\n O elevador nao pode subir mais  do que  no o numero de andares determinados \n espere.... ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {
                                    andamo = suband;
                                    Console.Clear();
                                }
                            }

                            else if (
                            comandos2 == "D"
                         || comandos2 == "d"
                         || comandos2 == "Decer"
                         || comandos2 == "decer")
                            {
                                Console.WriteLine($"\n - Para qual andar o  elevador ira decer ");
                                decand = int.Parse(Console.ReadLine());
                                if (decand > andpre)
                                {
                                    Console.WriteLine($"\n O elevador nao pode decer mais  do que  no o numero de andares determinados \n espere....   ");
                                    Thread.Sleep(7000);
                                    Console.Clear();
                                }
                                else
                                {

                                    andamo = decand;
                                    Console.Clear();
                                }
                            }

                            else if (
                                comandos2 == "Sair"
                                ||
                                comandos2 == "sair"
                                    )
                            {
                                sas++;
                                Console.Clear();
                            }
                            else if (comandos2 == "cancelar"|| comandos2 == "Cancelar")
                            {
                                exit = 1;
                            }
                            else
                            {
                                Console.WriteLine($"\n - {Nome}  Erro digite o solicitado!!!!");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($" - {Nome} Erro digite apenas: inicializar ou letra " + "{A}");
                    Console.WriteLine(" > 5");
                    Thread.Sleep(1000);
                    Console.WriteLine(" > 4");
                    Thread.Sleep(1000);
                    Console.WriteLine(" > 3");
                    Thread.Sleep(1000);
                    Console.WriteLine(" > 2");
                    Thread.Sleep(1000);
                    Console.WriteLine(" > 1");
                    Thread.Sleep(1000);
                    Console.WriteLine(" > 0");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
               
            }









        }
    
    }
}
