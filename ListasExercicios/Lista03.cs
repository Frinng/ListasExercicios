namespace Lista03Exer;

public class Lista01 {

    public static void Lista03()
    {
        bool Continuar = true;
        string DigitoEscolha;
        int Escolha;
        
        //Variaveis questao A
        int N1A = 0,N2A = 0;
        string N1a, N2a;
        
        //Variaveis questao B
        int N1B = 0,N2B = 0;
        string N1b, N2b;
        
        //Variaveis questao C
        int N1C = 0,N2C = 0;
        string N1c, N2c;
        
        //Variaveis questao D
        int N1D = 0, N2D = 0, N3D = 0;
        string N1d, N2d, N3d;
        
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
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero: ");
                        N1c = Console.ReadLine();
                        
                        Console.WriteLine("Digite um segundo numero: ");
                        N2c = Console.ReadLine();

                        if (int.TryParse(N1c, out N1C) && int.TryParse(N2c, out N2C)) {

                            if (N1C > N2C) {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N1C} é maior que {N2C}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }else if (N2C > N1C) {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N2C} é maior que {N1C}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                            }
                            else {
                                Console.Clear();
                                
                                Console.WriteLine($"O numero {N2C} é igual a {N1C}");
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }
                            
                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        break;
                    case 4:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero: ");
                        N1d = Console.ReadLine();
                        
                        Console.WriteLine("Digite um segundo numero: ");
                        N2d = Console.ReadLine();
                        
                        Console.WriteLine("Digite um segundo numero: ");
                        N3d = Console.ReadLine();

                        if (int.TryParse(N1d, out N1D) && int.TryParse(N2d, out N2D) && int.TryParse(N3d, out N3D)) {

                            if (N1D > N2D) {
                                Console.WriteLine($"O numero {N1D} é maior que {N2D}");
                                
                                if (N1D > N3D) {
                                    Console.WriteLine($"O numero {N1D} é maior que {N3D}");
                                }else if (N3D > N1D) {
                                    Console.WriteLine($"O numero {N3D} é maior que {N1D}");
                                }
                                else if(N1D == N3D ){
                                    Console.WriteLine($"O numero {N1D} é igual a {N3D}");
                                }
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }else if (N2D > N1D){
                                
                                Console.WriteLine($"O numero {N2D} é maior que {N1D}");
                                
                                if (N2D > N3D) {
                                    
                                    Console.WriteLine($"O numero {N2D} é maior que {N3D}");
                                    
                                }else if (N3D > N2D) {
                                    
                                    Console.WriteLine($"O numero {N3D} é maior que {N2D}");
                                    
                                }else if (N2D == N3D) {
                                    Console.WriteLine($"O numero {N2D} é igual a {N3D}");
                                }
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }else if(N3D > N1D){

                                Console.WriteLine($"O numero {N3D} é maior que {N1D}");
                                
                                if (N3D > N2D) {
                                    
                                    Console.WriteLine($"O numero {N3D} é maior que {N2D}");
                                    
                                }else if (N2D > N3D) {
                                    
                                    Console.WriteLine($"O numero {N2D} é maior que {N3D}");
                                    
                                }else if (N3D == N2D) {
                                    
                                    Console.WriteLine($"O numero {N3D} é igual a {N2D}");
                                    
                                }
                                
                                Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                                
                            }else if (N1D == N2D) {
                                Console.WriteLine($"O numero {N1D} é igual a {N2D}");
                                
                                
                                
                            }
                            
                        }else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
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