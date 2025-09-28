
using System;
using System.Collections.Generic;
using Models;
var opcaoMenu = -1;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("-------------------------------"); 
Console.WriteLine("--------Estacionamento---------"); 
Console.WriteLine("-------------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Configurações iniciais:");
Console.Write("Digite o preço inicial: R$ ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o preço por hora: R$ ");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);
do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("-------------------------------");    
    Console.WriteLine("Menu de Opções:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("1. Cadastrar Veiculos");
    Console.WriteLine("2. Listar Veiculos");
    Console.WriteLine("3. Remover Veiculos");
    Console.WriteLine("0. Sair");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("-------------------------------");    
    Console.ForegroundColor = ConsoleColor.White;
    if (int.TryParse(Console.ReadLine(), out opcaoMenu))
    {
        switch (opcaoMenu)
        {
            case 1:
                estacionamento.CadastrarVeiculo();
                break;
            case 2:
                estacionamento.ListarVeiculo();
                break;
            case 3:
                estacionamento.RemoverVeiculo();
                break;
            case 0:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor, insira um número.");
    }

    if (opcaoMenu != 0)
    {   
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
    }

} while (opcaoMenu != 0);
