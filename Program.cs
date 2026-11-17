Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");





















// Movies demolition = new Movies("Разрушение", "Драма", 2015, 7.0);
// Movies life = new Movies("Живое", "Ужасы", 2017, 6.6);
// Movies everest = new Movies("Эверест", "Приключения", 2015, 7.1);
// Movies prisoners = new Movies("Пленницы", "Триллер", 2013, 8.2);

// Console.WriteLine("Фильм 1");
// Console.WriteLine($"Название: {demolition.Name}");
// Console.WriteLine($"Жанр: {demolition.Genre}");
// Console.WriteLine($"Год: {demolition.Year}");
// Console.WriteLine($"Оценка: {demolition.Rating}");
// Console.WriteLine();

// Console.WriteLine("Фильм 2");
// Console.WriteLine($"Название: {life.Name}");
// Console.WriteLine($"Жанр: {life.Genre}");
// Console.WriteLine($"Год: {life.Year}");
// Console.WriteLine($"Оценка: {life.Rating}");
// Console.WriteLine();

// Console.WriteLine("Фильм 3");
// Console.WriteLine($"Название: {everest.Name}");
// Console.WriteLine($"Жанр: {everest.Genre}");
// Console.WriteLine($"Год: {everest.Year}");
// Console.WriteLine($"Оценка: {everest.Rating}");
// Console.WriteLine();

// Console.WriteLine("Фильм 4");
// Console.WriteLine($"Название: {prisoners.Name}");
// Console.WriteLine($"Жанр: {prisoners.Genre}");
// Console.WriteLine($"Год: {prisoners.Year}");
// Console.WriteLine($"Оценка: {prisoners.Rating}");
// Console.WriteLine();