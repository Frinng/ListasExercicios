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

        
        //Variaveis da letra A/1
        string N1Astring, N2Astring;
        int N1A = 0, N2A = 0;
        int ResultA = 0;
        
        //Variaveis da Letra B/2
        string N1Bstring;
        int N1B = 0;
        int ResultB = 0;
        
        //Variaveis da Letra C/3
        string N1Cstring;
        int N1C = 0;
        int ResultC = 0;
        
        //Variaveis da Letra D/4
        string N1Dstring;
        int N1D = 0;
        int ResultD = 0;
        
        //Variaveis da letra E/5
        string N1Estring, N2Estring;
        float N1E = 0, N2E = 0;
        float ResultE = 0;
        
        //Variaveis da letra F/6
        string N1Fstring;
        double N1F = 0;
        double ResultF = 0;
        
        //Variaveis da letra G/7
        string N1Gstring, N2Gstring;
        int N1G = 0, N2G = 0;
        int ResultG = 0;
        
        //Variaveis da letra H/8
        string N1Hstring;
        double N1H = 0;
        double ResultH = 0;
        
        //Variaveis da letra i/9
        string N1Istring, N2Istring;
        double N1I = 0, N2I = 0;
        double ResultI = 0;
        
        //Variaveis da Letra J/10
        string N1Jstring;
        double N1J = 0;
        double ResultJ = 0;
        
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
                        
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Estring = Console.ReadLine();
                        
                        Console.WriteLine("Digite outro Numero:");
                        N2Estring = Console.ReadLine();

                        if (float.TryParse(N1Estring, out N1E) && float.TryParse(N2Estring, out N2E)) {
                            

                            ResultE = N1E / N2E;
                            
                            Console.WriteLine($"{N1E} ÷ {N2E} = {ResultE:F2}");

                        }
                        else {
                                
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 6:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Fstring = Console.ReadLine();

                        if (double.TryParse(N1Fstring, out N1F))
                        {

                            ResultF = Math.Sqrt(N1F);
                            
                            Console.WriteLine($"O Quadrado de {N1F} é {ResultF:F2}");

                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 7:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Gstring = Console.ReadLine();
                        
                        Console.WriteLine("Digite outro Numero:");
                        N2Gstring = Console.ReadLine();

                        if (int.TryParse(N1Gstring, out N1G) && int.TryParse(N2Gstring, out N2G)) {
                            

                            ResultG = N2G - N1G;
                            
                            Console.WriteLine($"{N2G} + {N1G} = {ResultG}");

                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        
                        break;
                    case 8:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Hstring = Console.ReadLine();

                        if (double.TryParse(N1Hstring, out N1H))
                        {

                            ResultH = Math.Abs(N1H);
                            
                            Console.WriteLine($"O absoluto de {N1H} é {ResultH}");


                        }else {
                            
                            Funcoesuteis.DIGITEUMAOPCAOVALIDA();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        break;
                    case 9:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Istring = Console.ReadLine();
                        
                        Console.WriteLine("Digite outro Numero:");
                        N2Istring = Console.ReadLine();

                        if (double.TryParse(N1Istring, out N1I) && double.TryParse(N2Istring, out N2I)) {
                            

                            ResultI = N1I * N2I;
                            
                            Console.WriteLine($"{N1I:F0} x {N2I:F0} = {ResultI:F1}");

                        }
                        else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        
                        break;
                    case 10:
                        Console.Clear();
                        
                        Console.WriteLine("Digite um numero:");
                        N1Jstring = Console.ReadLine();

                        if (double.TryParse(N1Jstring, out N1J)) {

                            ResultJ = N1J % 2;

                            Console.WriteLine($"O resto de divisao de {N1J} = {ResultJ}");

                        }else {
                            
                            Funcoesuteis.DIGITEUMNUMEROINTEIRO();
                            
                        }
                        
                        Funcoesuteis.CLIQUEAQUIPARACONTINUAR();
                        
                        
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