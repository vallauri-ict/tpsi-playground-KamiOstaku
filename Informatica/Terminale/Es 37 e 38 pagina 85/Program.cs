using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_37_e_38_pagina_85
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] matrix = new char[4,4];
            int[,] matrix2 = new int[4, 4];
            string choice;
            do
            {
                Console.Clear();
                DrawMenu();
                MatrixFill(matrix2);

                do
                    choice = Console.ReadLine();
                while (choice.ToLower() != "a" && choice.ToLower() != "b" && choice.ToLower() != "q");

                Console.Clear();

                switch(choice.ToLower())
                {
                    case "a":
                        if(Es37(matrix))
                        {
                            Console.Write("La matrice è diversa");
                        }
                        else
                        {
                            Console.Write("La matrice non è diversa");
                        }
                        Console.ReadKey();
                    break;
                    
                    case "b":
                        Es38(matrix2);
                    break;
                }

            }
            while (choice.ToLower() != "q");

            Console.Write("Arrivederci...");
            
            Console.ReadKey();
        }

        private static void Es38(int[,] matrix)
        {
            PrintMatrix(matrix);

            string check = UnitaryCheck(matrix);

            Console.Write("\n" + check);
            Console.ReadKey();
        }

        private static string UnitaryCheck(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int ii = 0; ii  < matrix.GetLength(0); ii++)
                {
                    if(matrix[i, ii] == 0 && i == ii)
                    {
                        return "La matrice non è unitaria";
                    }
                    else if(matrix[i, ii] == 1 && i != ii)
                    {
                        return "La matrice non è unitaria";
                    }
                }
            }
            return "La matrice è unitaria";
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int ii = 0; ii < matrix.GetLength(1); ii++)
                {
                    Console.Write($"{matrix[i, ii]} ");
                }
                Console.WriteLine();
            }
        }

        private static void MatrixFill(int[,] matrix2)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for(int ii = 0; ii < matrix2.GetLength(1); ii++)
                {
                    matrix2[i, ii] = rnd.Next(0, 2); ;
                }
            }
        }

        private static bool Es37(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int ii = 0; ii < matrix.GetLength(1); ii++)
                {
                    if(matrix[i, ii] != 'a')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void DrawMenu()
        {
            Console.WriteLine("\n\tA. Es 37");
            Console.WriteLine("\n\tB. Es 38");
            Console.WriteLine("\n\tQ. Leave");
            Console.Write("\n\tMake your choise: ");
        }
    }
}
