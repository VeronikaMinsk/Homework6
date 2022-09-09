//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // Работает и так - Split(), зачем тогда кавычки?
//warning CS8602: Разыменование вероятной пустой ссылки - почему ругается на 5 строку?
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}

Console.WriteLine($"Числа введеные пользователем: ");
Console.WriteLine("{0}", string.Join(", ", array)); 
Console.WriteLine($"Кол-во чисел больше 0: {count}");