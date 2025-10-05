/*
 *Nome: Menu Principal
 *Nome do Criador: Pedro Henrique Vieira Lima
 *Data da Criação: 05/10/2025
 *Hora da Criação: 15:01
 */

namespace Lista03Exer;

public class Lista07 {

    public static void ListaO7() {
        
        bool Continuar = true;
        string DigitoEscolha;
        int Escolha;
        
        //Variavel A
        int N1A = 0;
        string N1Astring;

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

                        int i = 0;
                        
                        Console.WriteLine("Digite um numero:");
                        N1Astring = Console.ReadLine();
                        
                        if (int.TryParse(N1Astring, out N1A)) {

                            do {

                                if (N1A % 2 == 0) {
                                    
                                    Console.WriteLine(i);
                                    
                                }

                                i++;
                            } while (i <= N1A);
                            
                        }else{
                        
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                        
                        }
                        
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
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
                        break;
                    case 12:
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