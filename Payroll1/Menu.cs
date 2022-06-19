using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Payroll1
{
    internal class Menu
    {
        public void menu()


        {
            TextWriter file;
            file = new StreamWriter("Archivo.txt");

            double TransportAllow = 117_172;
            Data employer = new Data();

                    Console.WriteLine("Hi, Welcome to the Payroll, please insert the following data:");
                    Console.WriteLine("Enter your Document: ");
                    employer.Document1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your Firts name: ");
                    employer.FirstName1 = Console.ReadLine();
                    Console.WriteLine("Enter your Last name: ");
                    employer.LastName1 = Console.ReadLine();
                    Console.WriteLine("Enter your Salary: ");
                    employer.Salary1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("and finally, enter your Worked days: ");
                    employer.Worked_days = int.Parse(Console.ReadLine());
 

                //Print Data Employeer file
                file.WriteLine("You entered de Following Data:");
                file.WriteLine("-------------------------------");
                file.WriteLine("Document:" + employer.Document1);
                file.WriteLine("First Name:" + employer.FirstName1);
                file.WriteLine("Last Name:" + employer.LastName1);
                file.WriteLine("Salary:" + employer.Salary1);
                file.WriteLine("Worked Days:" + employer.Worked_days);
                file.Close();
                Console.Clear();


                //Print Data Employeer Console
               Console.WriteLine("You entered de Following Data:");
               Console.WriteLine("-------------------------------");
               Console.WriteLine("Document:" + employer.Document1);
               Console.WriteLine("First Name:" + employer.FirstName1);
               Console.WriteLine("Last Name:" + employer.LastName1);
               Console.WriteLine("Salary:" + employer.Salary1);
               Console.WriteLine("Worked Days:" + employer.Worked_days);



            do
            {

                char opcion;
                Console.WriteLine(" ");
                Console.WriteLine("Are you sure you entered the data corectly?:" );
                Console.WriteLine("If you enter the option 1: \nWe are going to continue with the program \nIf you enter the option 2: \nYou will have to enter the data again ");
                Console.WriteLine(" ");
                Console.WriteLine("Choose an option");
                Console.WriteLine(" \n 1. Yes  \n 2. No");

                opcion = char.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case '1':
                        Console.WriteLine(" This program will calculate your incomes and discounts");

                        //Incomes 

                        if (employer.Salary1 <= 2_000_000)
                        {

                            employer.Totallyincome1 = employer.Salary1 + TransportAllow;
                            Console.WriteLine(" ");
                            Console.WriteLine("Incomes:");
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Tranport Benefit: " + employer.Totallyincome1);

                        }
                        else
                        {
                            employer.Totallyincome1 = employer.Salary1;
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Salary:  " + employer.Totallyincome1);

                        }
                         // Discounts

                        employer.Income1 = employer.Salary1 / 30;
                        employer.Income1 = employer.Income1 * employer.Worked_days;

                        employer.Health1 = employer.Salary1 * 0.04;
                        employer.Pension1 = employer.Salary1 * 0.04;

                        Console.WriteLine(" ");
                        Console.WriteLine("Discounts");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Health Discount:" + employer.Health1);
                        Console.WriteLine("Pension Discount:" + employer.Pension1);

                        do 
                        {
                            char option;
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Enter 1 to start again or 2 to exit");
                            option = char.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case '1': Menu menu1 = new Menu(); menu1.menu(); break;
                                case '2': Console.WriteLine("Thanks for using the program");

                                        Environment.Exit(0); break;
                            }
                        }
                        while (true);

                        break;

                    case '2': Menu menu = new Menu(); menu.menu(); break;



                }
            }

            while (false);
            


            






        }






    }
}
