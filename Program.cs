﻿using System;
using System.Collections.Generic;

namespace Program //how accessible is the program
{
    class Program //where program is created
    {
        static void Main(string[] args) //declaration of "Main" program
        {
            // Weight Conversion
            Console.Write("What is your weight in lbs: ");
            int weight_lbs = Convert.ToInt32(Console.ReadLine()); //32 bit-signed int input
            double kg = weight_lbs / 2.205; //precise decimals
            kg = Math.Round(kg, 2); //rounded to (2) decimal

            string lbs = weight_lbs.ToString(); //re-assigning values
            string kgStr = kg.ToString();

            Console.WriteLine("Weight in Pounds (lbs): " + lbs); //printing result
            Console.WriteLine("Weight in Kilograms (kg): " + kgStr);
            Console.WriteLine("=========================================");

            // Length Conversion
            Console.Write("Give me a distance in Miles (mi): ");
            double len_mi = Convert.ToDouble(Console.ReadLine()); //can accept input with decimals
            double km = len_mi * 1.609;
            km = Math.Round(km, 2);

            string mi = len_mi.ToString(); //re-assigning values
            string kmStr = km.ToString();

            Console.WriteLine("Length in Miles (mi): " + mi); //printing result
            Console.WriteLine("Length converted to Kilometers (km): " + kmStr);
            Console.WriteLine("=========================================");

            // Temperature Conversion
            Console.Write("What's the temperature in fahrenheit: ");  //32 bit-signed int input
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            celsius = Math.Round(celsius, 2);

            string frt = fahrenheit.ToString(); //re-assigning values
            string cls = celsius.ToString();

            Console.WriteLine("Temperature in Fahrenheit (°f): " + frt);//printing result
            Console.WriteLine("Temperature converted to Celsius (°C): " + cls);
            Console.WriteLine("=========================================");

            // Average Age Calculation
            List<int> studentAgeList = new List<int>(); //creating a list

            for (int i = 1; i <= 10; i++) 
            {
                Console.Write($"Age of student {i}: "); //{i} == Age of student 1:, 2:, 3:, etc.
                int age = Convert.ToInt32(Console.ReadLine()); //age input
                studentAgeList.Add(age); //will add all input in studentAgeList until i = 10
            }

            Console.WriteLine(string.Join(", ", studentAgeList)); // concatenate list (,)

            int studentAgeSum = 0;
            foreach (int age in studentAgeList) //calculating sum of all input
            {
                studentAgeSum += age; 
            }

            double average = studentAgeSum / 10.0; //formula for average
            string ave = average.ToString(); //re-assigning value

            Console.WriteLine("The average age of the student is: " + ave); //print output
            Console.WriteLine("=========================================");

            // Story
            string[] chNames = { "Lumine", "Scara", "Raiden", "Barbatos", "Kaedehara" }; //array
            string[] worldNames = { "Teyvat", "Earth-918" };
            string[] weaponNames = { "Skyward", "Widsith", "The Catch" };
            string[] abilities = { "elemental resonance", "vision holder", "elemental reaction" };

            Console.WriteLine("There was once a lost star who was searching for her brother who she separated with. Her name was " + chNames[0] + " traveling the world of " + worldNames[0] + ". " +
                "A world which holds elemental powers where " + abilities[1] + "s from all nations help with its peace and safety. " + chNames[0] + " somehow has the ability of " + abilities[0] +
                " where she can connect with any elements on the world of " + worldNames[0] + ". There she met a loving mother named " + chNames[2] + ". She was helping her child " + chNames[1] +
                " farm for Rukkhashava Mushroom for them to feast on for dinner. " + chNames[0] + " did not realize that she encountered the nation's archon and casually spoke with her. " + chNames[0] +
                " soon violated the rules of " + chNames[2] + "'s nation and fought with her using her " + weaponNames[0] + " sword. To " + chNames[0] + "'s little knowledge, she did not know that " + chNames[1] +
                " also has the ability to fight with his " + weaponNames[1] + " weapon. " + chNames[2] + " wielded " + weaponNames[2] + " and tried to strike on " + chNames[0] +
                " but the wind was her guardian. The archon " + chNames[3] + " has come to her rescue together with his assistant, " + chNames[chNames.Length - 1] + ". While " + chNames[chNames.Length - 1] + ", as a double " + abilities[1] + ", help buy time for " + chNames[0] +
                " to escape, " + chNames[3] + " told her that her brother was in another world called " + worldNames[1] + " where Avengers exists. And with that, " + chNames[0] +
                " has gathered her strength to leap to another world and find her brother. That's how she ended up on our world with no weapons, abilities and just a laptop to study computer science while looking for her brother. The end.");
            Console.WriteLine("=========================================");
            
            // Right triangle
            Console.WriteLine("Right Triangle Number Pyramid"); 
            Console.Write("Enter a number: "); //input
            int n = int.Parse(Console.ReadLine());

            // Check if input is valid
            if (n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            else
            {
                // Print the number pattern
                for (int i = 1; i <= n; i++) //x (columns)
                {
                    for (int y = 1; y <= i; y++) //y (rows)
                    {
                        Console.Write(y + " "); //write a right triangle until input number
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("=========================================");
            // Summation
            Console.WriteLine("Summation");
            // Assigning variables
            Console.Write("Input: ");
            int input_num = Convert.ToInt32(Console.ReadLine()); //input
            int sum = 0;
            int[] formula_list = new int[input_num];

            // Formula of summation
            int index = 0;
            while (index < input_num) // if 9: index should be lower than 9
            {
                for (int i = 1; i <= input_num; i++) // starts at 1, increment to input#
                {
                    formula_list[index] = i; //adding all index
                    index++;
                    if (index >= input_num) // if 9 >= 9 it will stop
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Formula: " + string.Join("+", formula_list)); // will print formula

            // Summation formula
            for (int i = 1; i <= input_num; i++)
            {
                sum += i;
            }
            Console.WriteLine("Summation: " + sum); //print output

            Console.WriteLine("=========================================");
            // Inverse Triangle
            Console.WriteLine("Inverse Right Triangle Number Pyramid");

            int num_i_tri = 0;
            while (num_i_tri <= 0) //input should be more than 0
            {
                Console.Write("Input: ");
                string input_it = Console.ReadLine();
                if (int.TryParse(input_it, out int value_it))
                {
                    if (value_it <= 0)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                        num_i_tri = value_it; // if 9 = 9 stop
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input."); //for invalid input (negative int)
                }
            }
            for (int k = num_i_tri; k >= 1; k--) //decrements columns
            {
                for (int j = 1; j <= i; j++) // increments rows
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
