using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== C# TASKS ===");
            Console.WriteLine("1-6: Input and output");
            Console.WriteLine("7-12: Conditions");
            Console.WriteLine("13-18: Loops");
            Console.WriteLine("0: Exit");
            Console.Write("Choose task: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
                break;

            switch (choice)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    Console.Write("Specialty: ");
                    string specialty = Console.ReadLine();
                    Console.WriteLine($"My name is {name}. Age: {age}. City: {city}. Specialty: {specialty}");
                    break;

                case 2:
                    Console.Write("Product: ");
                    string product = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Product: {product}, Total: {price * quantity:F2} tenge");
                    break;

                case 3:
                    Console.Write("Age in years: ");
                    int years = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Months: " + years * 12);
                    Console.WriteLine("Days: " + years * 365);
                    break;

                case 4:
                    Console.Write("Hours worked: ");
                    double hours = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Pay per hour: ");
                    double rate = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Salary: {hours * rate:F2}");
                    break;

                case 5:
                    Console.Write("Distance in km: ");
                    double distance = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Fuel per 100 km: ");
                    double fuel = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Price per liter: ");
                    double fuelPrice = Convert.ToDouble(Console.ReadLine());
                    double liters = distance * fuel / 100;
                    Console.WriteLine($"Fuel needed: {liters:F2} liters");
                    Console.WriteLine($"Trip cost: {liters * fuelPrice:F2} tenge");
                    break;

                case 6:
                    double sumGrades = 0;
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.Write("Grade " + i + ": ");
                        sumGrades += Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Average: {sumGrades / 5:F2}");
                    break;

                case 7:
                    Console.Write("Age: ");
                    int userAge = Convert.ToInt32(Console.ReadLine());
                    if (userAge >= 18)
                        Console.WriteLine("Access allowed");
                    else
                        Console.WriteLine("Access denied");
                    break;

                case 8:
                    Console.Write("Number: ");
                    double number = Convert.ToDouble(Console.ReadLine());
                    if (number > 0)
                        Console.WriteLine("Positive");
                    else if (number < 0)
                        Console.WriteLine("Negative");
                    else
                        Console.WriteLine("Zero");
                    break;

                case 9:
                    Console.Write("Integer: ");
                    int evenNumber = Convert.ToInt32(Console.ReadLine());
                    if (evenNumber % 2 == 0)
                        Console.WriteLine("Even");
                    else
                        Console.WriteLine("Odd");
                    break;

                case 10:
                    Console.Write("First number: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Second number: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    if (a > b)
                        Console.WriteLine("Maximum: " + a);
                    else if (b > a)
                        Console.WriteLine("Maximum: " + b);
                    else
                        Console.WriteLine("Numbers are equal");
                    break;

                case 11:
                    Console.Write("Score from 0 to 100: ");
                    int score = Convert.ToInt32(Console.ReadLine());
                    if (score < 0 || score > 100)
                        Console.WriteLine("Invalid score");
                    else if (score < 50)
                        Console.WriteLine("Fail");
                    else if (score < 70)
                        Console.WriteLine("Satisfactory");
                    else if (score < 90)
                        Console.WriteLine("Good");
                    else
                        Console.WriteLine("Excellent");
                    break;

                case 12:
                    Console.Write("Order amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    double delivery;
                    if (amount < 5000)
                        delivery = 1000;
                    else if (amount <= 10000)
                        delivery = 500;
                    else
                        delivery = 0;
                    Console.WriteLine($"Goods: {amount:F2} tenge");
                    Console.WriteLine($"Delivery: {delivery:F2} tenge");
                    Console.WriteLine($"Total: {amount + delivery:F2} tenge");
                    break;

                case 13:
                    Console.Write("N: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= n1; i++)
                        Console.Write(i + " ");
                    Console.WriteLine();
                    break;

                case 14:
                    Console.Write("N: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 2; i <= n2; i += 2)
                        Console.Write(i + " ");
                    Console.WriteLine();
                    break;

                case 15:
                    Console.Write("N: ");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    int total = 0;
                    for (int i = 1; i <= n3; i++)
                        total += i;
                    Console.WriteLine("Sum: " + total);
                    break;

                case 16:
                    Console.Write("Number: ");
                    int tableNumber = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                        Console.WriteLine($"{tableNumber} x {i} = {tableNumber * i}");
                    break;

                case 17:
                Console.Write("How many numbers? ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    if (count <= 0)
                    {
                        Console.WriteLine("Enter a number greater than zero");
                        break;
                    }
                    double totalSum = 0;
                    for (int i = 1; i <= count; i++)
                    {
                        Console.Write("Enter number: ");
                        totalSum += Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Sum: {totalSum:F2}");
                    Console.WriteLine($"Average: {totalSum / count:F2}");
                    break;

                case 18:
                    int secret = 37;
                    int guess;
                    int attempts = 0;
                    do
                    {
                        Console.Write("Guess the number: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                        if (guess > secret)
                            Console.WriteLine("Too high");
                        else if (guess < secret)
                            Console.WriteLine("Too low");
                    }
                    while (guess != secret);
                    Console.WriteLine($"Correct! Attempts: {attempts}");
                    break;

                default:
                    Console.WriteLine("Invalid task number");
                    break;
            }
        }
    }
}