﻿// See https://aka.ms/new-console-template for more information

////////////////////1.String ustida amallar
string word = "TeLefOn";

int number = Convert.ToInt32(Console.ReadLine());

string result = (number >= word.Length) ? word.ToUpper() : word.ToLower();
Console.WriteLine(result);

/////////////////// 2. Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
int x = 15;
int y = 10;

if (x > y) 
{
    Console.WriteLine("X is greater than Y");
} 
else if (x < y)
{
    Console.WriteLine("Y is greater than X");
}
else if (x == y)
{
    Console.WriteLine("Y and X are equal");
}
else 
{
    Console.WriteLine("Y and X are not compatable");
}

///////////////////// 3.Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib, natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!

string weekday = Console.ReadLine();

string translated = weekday.ToLower() switch 
{
    "monday"    => "dushanba",
    "tuesday"   => "seshanba",
    "wednesday" => "chorshanba",
    "thursday"  => "payshanba",
    "friday"    => "juma",
    "saturday"  => "shanba",
    "sunday"    => "yakshanba"
};

Console.WriteLine(translated);
