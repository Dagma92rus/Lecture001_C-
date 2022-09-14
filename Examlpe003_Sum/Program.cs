int numberA = new Random().Next(1,10);// 1 2 3 4 ... 9
Console.WriteLine($"Первое чилсло «{numberA}»");
int numberB = new Random().Next(1,10);
Console.WriteLine($"Второе чилсло «{numberB}»");
int result = numberA+numberB;
Console.WriteLine($"Сумма «{result}»");