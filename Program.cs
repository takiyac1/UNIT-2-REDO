// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello! Welcome to my all you can eat buffet. We charge $9.99 per person. Water is free, however soda is two dollars. How many people are in your group? (Please have a party of 6 or less people.)");

        int people = int.Parse(Console.ReadLine());
        if (people > 6)
        {

            Console.WriteLine("Sorry, you have too many people in your party. Goodbye.");
            System.Environment.Exit(0);
        }

        Console.WriteLine();



        Console.WriteLine("A table for " + people + "... Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or soda.");


        string drink;
        int sodacount = 0;
        int watercount = 0;


        int i = 1;
        while (i <= people)

        {
            Console.WriteLine("Person number " + (i++) + ", soda or water? ");
            

            drink =
                 Console.ReadLine();

            Console.WriteLine(drink + " , that's a great choice.");

            if (drink == "soda")
                sodacount++;
            


            else if (drink == "water")
                watercount++;

           

            else Console.WriteLine("Sorry, we don't serve that.");
            

            Console.WriteLine();
        }


            







            drink = Console.ReadLine();


            string soda;
            string water;




            Console.WriteLine("Okay. So that is " + (watercount++) + " waters and " + (sodacount++) + "  sodas. I'll be right back. Feel free to grab your food.");
            Console.WriteLine();


       
            double p = 9.99;
            int a = 2;


        double totpop = sodacount++ * a;
        double food = people * p;
        double price = totpop + food;

            Console.WriteLine("Here's your bill! Total price:  $"  + (price));
        }





       
    }









