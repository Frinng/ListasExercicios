﻿/*
 *Nome: Um Conjunto de Todas as Listas Feitas ate agora
 *Nome do Criador: Pedro Henrique Vieira Lima
 *Data da Criação: 02/10/2025
 *Hora da Criação: 22:59
 */


using System;
using Lista03Exer;

public class ConjuntoListas {
    public static void Main() {
 
        Random TwoFA = new Random();
        
        int chave2FA = TwoFA.Next(111111, 999999);
        bool Continuar = true;
        string escolha;
        string escolha1;
        string usuario = "";
        string senha = "";
        string digitodousuario;
        string digitodousuario2;
        string digitodousuario3;
        int chavedigitada = 0;
        int tentativas = 0;
        bool ContinuarCadastro = true;
        
        

        do{
            Console.Clear();
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|                    Menu                     |");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine(" ");
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("| 1-Cadastrar                                 |");
            Console.WriteLine("| 2-Entrar                                    |");
            Console.WriteLine("| 3-Sair                                      |");
            Console.WriteLine("-----------------------------------------------");
            
            escolha = Console.ReadLine().ToUpper();

            switch (escolha) {
                case "1":
                case "CADASTRAR":
                    Console.Clear();
                    
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|          Digite o Nome Do Usuario           |");
                    Console.WriteLine("-----------------------------------------------");
                    usuario = Console.ReadLine();
                    
                    Console.WriteLine(" ");
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|              Digite sua senha               |");
                    Console.WriteLine("-----------------------------------------------");
                    senha = Console.ReadLine();
                    
                    Console.Clear();
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|             Usuario Cadastrado              |");
                    Console.WriteLine("-----------------------------------------------");
                    
                    Console.WriteLine(" ");
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine($"| Este é o seu Codigo 2FA:    {chave2FA}          |");
                    Console.WriteLine("-----------------------------------------------");
                    
                    Console.WriteLine(" ");
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|   Pressione qualquer tecla para continuar   |");
                    Console.WriteLine("-----------------------------------------------");
                
                    Console.ReadKey();
                    
                    
                    break;
                case "2":
                case "ENTRAR":
                    Console.Clear();

                    do
                    {
                        tentativas++;
                        
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("|          Digite o Nome Do Usuario           |");
                        Console.WriteLine("-----------------------------------------------");
                        digitodousuario = Console.ReadLine();
                    
                        Console.WriteLine(" ");
                    
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("|              Digite sua senha               |");
                        Console.WriteLine("-----------------------------------------------");
                        digitodousuario2 = Console.ReadLine();

                        if (digitodousuario == usuario && digitodousuario2 == senha) {
                            
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("|          Digite o Seu Codigo 2FA:           |");
                            Console.WriteLine("-----------------------------------------------");
                            digitodousuario3 = Console.ReadLine();

                            if (int.TryParse(digitodousuario3, out chavedigitada)) {

                                if (chavedigitada == chave2FA) {
                                    
                                    Console.Clear();
                                    
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("|             Entrando no Sistema             |");
                                    Console.WriteLine("-----------------------------------------------");
                        
                                    Console.WriteLine(" ");
                    
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("|   Pressione qualquer tecla para continuar   |");
                                    Console.WriteLine("-----------------------------------------------");
                        
                                    Console.ReadKey();

                                    MenuDasAtividades.MenuPrincipal();
                        
                        
                                    Continuar = false;
                                    
                                }
                                else {
                                    
                                    Console.Clear();
                        
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("|          Seu Codigo 2FA Esta errado         |");
                                    Console.WriteLine("-----------------------------------------------");
                        
                                    Console.WriteLine(" ");
                                    
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("|   Pressione qualquer tecla para continuar   |");
                                    Console.WriteLine("-----------------------------------------------");
                
                                    Console.ReadKey();
                                    
                                }
                                
                                
                            }
                            else {
                                
                                Console.Clear();
                    
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("|          Digite uma opção Valida            |");
                                Console.WriteLine("-----------------------------------------------");
                
                                Console.WriteLine(" ");
                    
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("|   Pressione qualquer tecla para continuar   |");
                                Console.WriteLine("-----------------------------------------------");
                
                                Console.ReadKey();
                                
                            }
                            
                        }else {
                            
                            Console.Clear();
                        
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("|       Sua Senha ou Usuario esta Errado      |");
                            Console.WriteLine("-----------------------------------------------");
                        
                        
                            Console.WriteLine(" ");
                    
                    
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("|   Pressione qualquer tecla para continuar   |");
                            Console.WriteLine("-----------------------------------------------");
                
                            Console.ReadKey();
                            
                        }
                        
                    } while (tentativas < 3 || (digitodousuario == usuario && digitodousuario2 == senha &&  chavedigitada == chave2FA));
                    
                    Console.Clear();
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|        Você não possui mais tentativa       |");
                    Console.WriteLine("-----------------------------------------------");
                    
                    Console.WriteLine(" ");
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|   Pressione qualquer tecla para continuar   |");
                    Console.WriteLine("-----------------------------------------------");
                
                    Console.ReadKey();
                    
                    break;
                case "3":
                case "Sair":
                    
                    Console.Clear();
                    
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|               Saindo do Sistema             |");
                    Console.WriteLine("-----------------------------------------------");
                
                    Console.WriteLine(" ");
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|   Pressione qualquer tecla para continuar   |");
                    Console.WriteLine("-----------------------------------------------");
                
                    Console.ReadKey();
                    
                    Environment.Exit(0);
                    
                    break;
                default:
                    
                    Console.Clear();
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|          Digite uma opção Valida            |");
                    Console.WriteLine("-----------------------------------------------");
                
                    Console.WriteLine(" ");
                    
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("|   Pressione qualquer tecla para continuar   |");
                    Console.WriteLine("-----------------------------------------------");
                
                    Console.ReadKey();
                    
                    break;
            }
        }while(Continuar);
    }
}