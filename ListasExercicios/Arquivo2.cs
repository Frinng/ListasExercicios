﻿/*
 *Nome: Menu Principal
 *Nome do Criador: Pedro Henrique Vieira Lima
 *Data da Criação: 02/10/2025
 *Hora da Criação: 22:59
 */


namespace Lista03Exer;

public class Arquivo2 {
    
    public static void MenuPrincipal()
    {

        //Variaveis
        bool Continuar = true;
        string EscolhaDigitado;
        int Escolha;

        do {
            Console.Clear();
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|                  Listas                     |");
            Console.WriteLine("-----------------------------------------------");
            
            Console.WriteLine(" ");
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("| 1-Lista 02                                  |");
            Console.WriteLine("| 2-Lista 03A                                 |");
            Console.WriteLine("| 3-Lista 03B                                 |");
            Console.WriteLine("| 4-Lista 07                                  |");
            Console.WriteLine("| 5-Voltar ao Menu                            |");
            Console.WriteLine("| 6-Sair                                      |");
            Console.WriteLine("-----------------------------------------------");
            EscolhaDigitado = Console.ReadLine();

            if (int.TryParse(EscolhaDigitado,out Escolha)){
                switch (Escolha) {
                    case 1:
                        
                        Lista02.ListaO2();
                        
                        break;
                    case 2:
                        
                        Lista01.Lista03();
                        
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        
                        Funcoesuteis.VOLTANDOAOMENU();

                        Arquivo1.Main();
                        
                        break;
                    case 6:
                        
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