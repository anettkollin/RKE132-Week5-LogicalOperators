﻿// Math > 90; Biology >= 90; Chemistry >= 90; 

using System.Threading.Channels;

int math, biology, chemistry;

Console.WriteLine("Enter your Math results");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology results");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry results");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}

