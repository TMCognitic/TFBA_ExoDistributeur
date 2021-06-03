using ExoDistributeur.Models;
using System;

namespace ExoDistributeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Distributeur distributeur = new Distributeur();

            for (int i = 0; i < 10; i++)
            {
                Boisson boisson = distributeur.Get();
                Console.WriteLine(boisson.Nom);
            }
        }
    }
}
