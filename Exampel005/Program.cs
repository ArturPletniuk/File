﻿Console.Write("Введите имя пользователя:");
string user = Console.ReadLine();
if(user.ToLower() == "маша")
{
    Console.WriteLine("Ура это она");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(user);
}    
