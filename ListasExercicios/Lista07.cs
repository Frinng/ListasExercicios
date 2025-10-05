/*
 *Nome: Menu Principal
 *Nome do Criador: Pedro Henrique Vieira Lima
 *Data da Criação: 05/10/2025
 *Hora da Criação: 15:01
 */

using System.Formats.Asn1;

namespace Lista03Exer;

public class Lista07 {

    public static void ListaO7() {
        
        bool Continuar = true;
        string DigitoEscolha;
        int Escolha;
        
        //Variavel A
        int N1A = 0;
        string N1Astring;
        int A = 0;
        
        //Variavel B
        int N1B = 0;
        string N1Bstring;
        int B = 0;
        int ResultB = 1;
        
        //Varivavel da Letra C
        int N1C = 0;
        string N1Cstring;
        int SomaC = 0;
        int C = 1;
        
        //Varivavel da Letra E
        int N1E = 0;
        string N1Estring;
        int SomaE = 0;
        int E = 1;
        
        //Variavel F
        int N1F = 0;
        string N1Fstring;
        int F = 0;
        
        //Variavel G
        int N1G = 0;
        string N1Gstring;
        int G = 0;
        
        //Variavel H
        int N1H = 0;
        string N1Hstring;
        int H = 0;
        int ResultH = 1;
        
        //Varivavel da Letra i
        int N1I = 0;
        string N1Istring;
        int SomaI = 0;
        int I = 1;
        
        //Varivavel da Letra E
        int N1K = 0;
        string N1Kstring;
        int SomaK = 0;
        int K = 1;
        
        //Variavel L
        int N1L = 0;
        string N1Lstring;
        int L = 0;

        do {
            
            Console.Clear();
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|                 Listas  07                  |");
            Console.WriteLine("-----------------------------------------------");
            
            Console.WriteLine(" ");
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("| 1-Atividade A                               |");
            Console.WriteLine("| 2-Atividade B                               |");
            Console.WriteLine("| 3-Atividade C                               |");
            Console.WriteLine("| 4-Atividade D                               |");
            Console.WriteLine("| 5-Atividade E                               |");
            Console.WriteLine("| 6-Atividade F                               |");
            Console.WriteLine("| 7-Atividade G                               |");
            Console.WriteLine("| 8-Atividade H                               |");
            Console.WriteLine("| 9-Atividade I                               |");
            Console.WriteLine("| 10-Atividade J                              |");
            Console.WriteLine("| 11-Atividade k                              |");
            Console.WriteLine("| 12-Atividade L                              |");
            Console.WriteLine("| 13-Voltar ao Menu                           |");
            Console.WriteLine("| 14-Sair                                     |");
            Console.WriteLine("-----------------------------------------------");
            DigitoEscolha = Console.ReadLine();

            if (int.TryParse(DigitoEscolha, out Escolha)) {

                switch (Escolha) {

                    case 1:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Astring = Console.ReadLine();
                        
                        if (int.TryParse(N1Astring, out N1A) && N1A >= 0) {
                            Console.Clear();
                            
                            do {

                                if (A % 2 == 0) {
                                    
                                    Console.WriteLine(A);
                                    
                                }

                                A++;
                            } while (A <= N1A);
                            Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                            
                        }else{
                        
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                        
                        }
                        
                        break;
                    case 2:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Bstring = Console.ReadLine();

                        if (int.TryParse(N1Bstring, out N1B)) {
                            Console.Clear();
                            
                            do
                            {

                                ResultB = N1B * B;
                                
                                Console.WriteLine($"{N1B} X {B} = {ResultB}");

                                B++;
                            } while (B <= 10);
                            
                            Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        break;
                    case 3:
                        Console.Clear();

                        do {
                            Console.WriteLine("Digite um numero:");
                            N1Cstring = Console.ReadLine();

                            if (int.TryParse(N1Cstring, out N1C)) {

                                SomaC += N1C;

                                C++;
                            }else {
                            
                                Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                            }   
                        } while (C <= 10);
                        
                        Console.Clear();
                        
                        Console.WriteLine($"O Resultado das somas dos numeros e {SomaC}");
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 4:
                        Console.Clear();
                        
                        Console.WriteLine("O Arquivo 1 ja conta para essa atividade.");
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 5:
                        Console.Clear();

                        do
                        {
                            Console.WriteLine("Digite um numero:");
                            N1Estring = Console.ReadLine();

                            if (int.TryParse(N1Estring, out N1E)) {

                                if (N1E > 0) {
                                    SomaE += N1E;
                                }

                                E++;
                            }else {
                            
                                Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                            }   
                        } while (E <= 10);
                        
                        Console.Clear();
                        
                        Console.WriteLine($"O Resultado das somas dos numeros e {SomaE}");
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 6:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Fstring = Console.ReadLine();
                        
                        if (int.TryParse(N1Fstring, out N1F) && N1F >= 0) {
                            Console.Clear();
                            
                            do {

                                if (F % 2 == 0) {
                                    
                                    Console.WriteLine(F);
                                    
                                }

                                F++;
                            } while (F <= N1F);
                            Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                            
                        }else{
                        
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                        
                        }
                        
                        break;
                    case 7:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Gstring = Console.ReadLine();
                        
                        if (int.TryParse(N1Gstring, out N1G) && N1G >= 0) {
                            Console.Clear();
                            
                            do {

                                if (G % 2 == 0) {
                                    
                                    Console.WriteLine(G);
                                    
                                }

                                F++;
                            } while (G <= N1G);
                            Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                            
                        }else{
                        
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                        
                        }
                        
                        break;
                    case 8:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Hstring = Console.ReadLine();

                        if (int.TryParse(N1Hstring, out N1H)) {
                            Console.Clear();
                            
                            do
                            {

                                ResultH = N1H * H;
                                
                                Console.WriteLine($"{N1H} X {H} = {ResultH}");

                                H++;
                            } while (H <= 10);
                            
                            Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        break;
                    case 9:
                        Console.Clear();

                        do {
                            Console.WriteLine("Digite um numero:");
                            N1Istring = Console.ReadLine();

                            if (int.TryParse(N1Istring, out N1I)) {

                                SomaI += N1I;

                                I++;
                            }else {
                            
                                Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                            }   
                        } while (I <= 10);
                        
                        Console.Clear();
                        
                        Console.WriteLine($"O Resultado das somas dos numeros e {SomaI}");
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 10:
                        Console.Clear();
                        
                        Console.WriteLine("O Arquivo 1 ja conta para essa atividade.");

                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 11:
                        Console.Clear();

                        do
                        {
                            Console.WriteLine("Digite um numero:");
                            N1Kstring = Console.ReadLine();

                            if (int.TryParse(N1Kstring, out N1K)) {

                                if (N1K > 0) {
                                    SomaK += N1K;
                                }

                                K++;
                            }else {
                            
                                Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                            }   
                        } while (K <= 10);
                        
                        Console.Clear();
                        
                        Console.WriteLine($"O Resultado das somas dos numeros e {SomaK}");
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        
                        break;
                    case 12:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Lstring = Console.ReadLine();
                        
                        if (int.TryParse(N1Lstring, out N1L) && N1L >= 0) {
                            Console.Clear();
                            
                            do {

                                if (L % 2 == 0) {
                                    
                                    Console.WriteLine(L);
                                    
                                }

                                L++;
                            } while (L <= N1L);
                            Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                            
                        }else{
                        
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                        
                        }
                        
                        
                        break;
                    case 13:
                        
                        Funcoesuteis.VOLTANDOAOMENU();

                        Arquivo2.MenuPrincipal();
                        
                        break;
                    case 14:
                        
                        Funcoesuteis.SAINDODOSISTEMA();
                        
                        Environment.Exit(0);
                        
                        break;
                    default:
                        
                        Funcoesuteis.DIGITEUMAOPCAOVALIDA();
                        
                        break;
                    
                }
            }else {
                
                Funcoesuteis.DIGITEUMAOPCAOVALIDA();
                
            }
        } while (Continuar);
    }
}