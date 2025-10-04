/*
 *Nome: Menu Principal
 *Nome do Criador: Pedro Henrique Vieira Lima
 *Data da Criação: 04/10/2025
 *Hora da Criação: 20:41
 */

namespace Lista03Exer;

public class Lista02 {

    public static void ListaO2()
    {

        bool Continuar = true;
        string DigitoEscolha;
        int Escolha;

        
        //Variaveis da letra A
        string N1Astring, N2Astring;
        int N1A = 0, N2A = 0;
        int ResultA = 0;
        
        //Variaveis da Letra B
        string N1Bstring;
        int N1B = 0;
        int ResultB = 0;
        
        //Variaveis da Letra C
        string N1Cstring;
        int N1C = 0;
        int ResultC = 0;
        
        //Variaveis da Letra D
        string N1Dstring;
        int N1D = 0;
        int ResultD = 0;
        
        do {
            
            Console.Clear();
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|                 Listas  02                  |");
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
            Console.WriteLine("| 11-Voltar ao Menu                           |");
            Console.WriteLine("| 12-Sair                                     |");
            Console.WriteLine("-----------------------------------------------");
            DigitoEscolha = Console.ReadLine();

            if (int.TryParse(DigitoEscolha, out Escolha)) {

                switch (Escolha) {
                    
                    case 1:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Astring = Console.ReadLine();
                        
                        Console.WriteLine("Digite outro Numero:");
                        N2Astring = Console.ReadLine();

                        if (int.TryParse(N1Astring, out N1A) && int.TryParse(N2Astring, out N2A)) {
                            

                            ResultA = N1A + N2A;
                            
                            Console.WriteLine($"{N1A} + {N2A} = {ResultA}");

                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        
                        break;
                    case 2:
                        
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Bstring = Console.ReadLine();

                        if (int.TryParse(N1Bstring, out N1B))
                        {

                            ResultB = N1B * 2;
                            
                            Console.WriteLine($" O dobro de {N1B} = {ResultB}");

                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 3:
                        
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Cstring = Console.ReadLine();

                        if (int.TryParse(N1Cstring, out N1C))
                        {

                            ResultC = N1C / 2;
                            
                            Console.WriteLine($"A metade de {N1C} = {ResultC}");

                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 4:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Dstring = Console.ReadLine();

                        if (int.TryParse(N1Dstring, out N1D))
                        {

                            ResultD = N1D * N1D;
                            
                            Console.WriteLine($"O Quadrado de {N1D} é {ResultD}");

                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        
                        Funcoesuteis.VOLTANDOAOMENU();

                        MenuDasAtividades.MenuPrincipal();
                        
                        break;
                    case 12:
                        
                        Funcoesuteis.SAINDODOSISTEMA();
                        
                        Environment.Exit(0);
                        
                        break;
                    default:
                        
                        Funcoesuteis.DIGITEUMAOPCAOVALIDA();
                        
                        break;
                    
                }
                
                
            }
            else {
                
                Funcoesuteis.DIGITEUMAOPCAOVALIDA();
                
            }
            
            
        } while (Continuar);

    }
}