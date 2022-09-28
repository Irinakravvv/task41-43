// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Укажите количество вводимых чисел");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 0)
{
    Console.WriteLine("Указано неверное количество чисел. Количество вводимых чисел должно быть > 0. Повторите ввод");
    a = Convert.ToInt32(Console.ReadLine());
}

int[] numbers = new int[a];

int count = 0;
for (int i = 0; i < a; i++)
{
    Console.WriteLine($"Введите {i + 1} число");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0) count++;
}

Console.WriteLine($"Было введено {count} чисел больше 0");