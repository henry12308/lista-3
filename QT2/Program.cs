﻿/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de 
Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade. 
Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas missões ele completou.
2. Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3. Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
• Fácil: 50 pontos por inimigo
• Médio: 100 pontos por inimigo

@Lista: 02 - Condicionais
@Autor: João Henry Brito Cavalcante 
@Data: 03/00/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        string? nivel;
        int missoes, inimigos, final = 0,final1 = 0,final2 = 0,final3 = 0;
        
        Console.WriteLine(" Quantas missões foram completadas?");
        int.TryParse(Console.ReadLine(), out missoes);
        for (int i = 0; i < missoes; i++)
        {
            Console.WriteLine("Para cada missão, qual o nível de dificuldade?");
            nivel = Console.ReadLine();
            if (nivel == "facil")
            {
                Console.WriteLine("Quantos inimigos você derrotou nessa missão?");
                int.TryParse(Console.ReadLine(), out inimigos);
                final = 50 * inimigos;
            }
             else if (nivel == "medio")
            {
                Console.WriteLine("Quantos inimigos você derrotou nessa missão?");
                int.TryParse(Console.ReadLine(), out inimigos);
                final1 = 100 * inimigos;
            }
             else if (nivel == "dificil")
            {
                Console.WriteLine("Quantos inimigos você derrotou nessa missão?");
                int.TryParse(Console.ReadLine(), out inimigos);
                final2 = 150 * inimigos;
            }
            final3=final+final1+final2;
        }
  Console.WriteLine($"Você ganhou {final3} pontos!");
    }
}