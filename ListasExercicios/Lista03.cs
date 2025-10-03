namespace Lista03Exer;

public class Lista01 {

    public static void Lista03()
    {
        bool Continuar = true;
        string DigitoEscolha;
        int Escolha;
        int N1A = 0,N2A = 0;
        string N1a, N2a;
        int N1B = 0,N2B = 0;
        string N1b, N2b;
        
        do {
            Console.Clear();
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|                 Listas  03                  |");
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
            Console.WriteLine("| 11-Voltar ao Menu                            |");
            Console.WriteLine("| 12-Sair                                      |");
            Console.WriteLine("-----------------------------------------------");
            DigitoEscolha = Console.ReadLine();

            if (int.TryParse(DigitoEscolha, out Escolha)) {
                switch (Escolha) {
                 
                    case 1:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero: ");
                        N1a = Console.ReadLine();
                        
                        Console.WriteLine("Digite um segundo numero: ");
                        N2a = Console.ReadLine();

                        if (int.TryParse(N1a, out N1A) && int.TryParse(N2a, out N2A)) {

                            if (N1A > N2A) {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N1A} é maior que {N2A}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }else if (N2A > N1A) {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N2A} é maior que {N1A}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                            }
                            else {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N2A} é igual a {N1A}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }
                            
                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        break;
                    case 2:
                        
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero: ");
                        N1b = Console.ReadLine();
                        
                        Console.WriteLine("Digite um segundo numero: ");
                        N2b = Console.ReadLine();

                        if (int.TryParse(N1b, out N1B) && int.TryParse(N2b, out N2B)) {

                            if (N1B > N2B) {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N1B} é maior que {N2B}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }else if (N2B > N1B) {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N2B} é maior que {N1B}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                            }
                            else {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N2B} é igual a {N1B}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }
                            
                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
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
            }else{
                
                Funcoesuteis.DIGITEUMAOPCAOVALIDA();
                
            }
            
            
        } while (Continuar);
    }
}