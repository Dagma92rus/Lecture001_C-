Console.WriteLine ("Введите имя пользователя на латинице, например Masha");
string username = Console.ReadLine();

if (username.ToLower() == "masha") //добавление .ToLower() изменяет все введёные буквы в буквы нижнего регистра. Благодаря чему проще узнать "особого" пользователя.
    {
        Console.WriteLine("Ура это же, Маша!");
    }
else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }