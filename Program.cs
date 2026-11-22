//Probe.Run();

// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("   Александр   ", 150);
// Hero sergey = new Hero("Сергей", 110);

// alexander.TakeDamage(10);
// alexander.Heal(10);

// Guild guild = new Guild("Гильдия героев");


// guild.Heroes.Add(yaroslav);
// guild.Heroes.Add(anastasia);
// guild.Heroes.Add(artem);
// guild.Heroes.Add(alexander);
// guild.Heroes.Add(sergey);


// Console.WriteLine($">>> {guild.Name}: перекличка <<<");
// Console.WriteLine($"Участников: {guild.Heroes.Count}");


// if (guild.Heroes.Count > 0) {
//     Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
//     Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
// }

// Console.WriteLine();
// foreach (Hero hero in guild.Heroes) {
//     Console.WriteLine(hero.GetInfo());
//     Console.WriteLine();
// }






















Movies demolition = new Movies("Разрушение", "Драма", 2015, 7.0);
Movies life = new Movies("Живое", "Ужасы", 2017, 6.6);
Movies everest = new Movies("Эверест", "Приключения", 2015, 7.1);
Movies prisoners = new Movies("Пленницы", "Триллер", 2013, 8.2);

Console.WriteLine("Фильм 1");
Console.WriteLine($"Название: {demolition.Name}");
Console.WriteLine($"Жанр: {demolition.Genre}");
Console.WriteLine($"Год: {demolition.Year}");
Console.WriteLine($"Оценка: {demolition.Rating}");
Console.WriteLine();

Console.WriteLine("Фильм 2");
Console.WriteLine($"Название: {life.Name}");
Console.WriteLine($"Жанр: {life.Genre}");
Console.WriteLine($"Год: {life.Year}");
Console.WriteLine($"Оценка: {life.Rating}");
Console.WriteLine();

Console.WriteLine("Фильм 3");
Console.WriteLine($"Название: {everest.Name}");
Console.WriteLine($"Жанр: {everest.Genre}");
Console.WriteLine($"Год: {everest.Year}");
Console.WriteLine($"Оценка: {everest.Rating}");
Console.WriteLine();

Console.WriteLine("Фильм 4");
Console.WriteLine($"Название: {prisoners.Name}");
Console.WriteLine($"Жанр: {prisoners.Genre}");
Console.WriteLine($"Год: {prisoners.Year}");
Console.WriteLine($"Оценка: {prisoners.Rating}");
Console.WriteLine();

// пр 3
Console.WriteLine($"Рейтинг до: {everest.Rating}");

everest.AddScore(10);
Console.WriteLine($"После допустимой оценки: {everest.Rating}");

everest.AddScore(-2); 
Console.WriteLine($"После недопустимой оценки: {everest.Rating}");

// пр 4
List<Movies> movieList = new List<Movies>();
movieList.Add(demolition);
movieList.Add(life);
movieList.Add(everest);


Console.WriteLine($"\n>>> Мой список фильмов <<<");
Console.WriteLine($"Всего фильмов: {movieList.Count}");

if (movieList.Count > 0) {
    Console.WriteLine($"Первый фильм: {movieList[0].Name}");
    Console.WriteLine($"Последний фильм: {movieList[movieList.Count - 1].Name}");
}

Console.WriteLine("\nСписок всех фильмов:");
foreach (Movies movie in movieList) {
    Console.WriteLine($"{movie.Name} ({movie.Year}) - Жанр: {movie.Genre}, Рейтинг: {movie.Rating}");
}

Movies plennici = new Movies("Пленницы", "Триллер", 2013, 8.2);
movieList.Add(plennici);
Console.WriteLine($"\nПосле добавления Пленниц: {movieList.Count} фильма(ов).");


int modernMoviesCount = 0;
foreach (Movies movie in movieList) {
    if (movie.Year >= 2015) {
        modernMoviesCount++;
    }
}
Console.WriteLine($"Фильмов, выпущенных в 2015 году или позже: {modernMoviesCount}");

Console.WriteLine($"\nРейтинг Эвереста до изменения: {everest.Rating}");
everest.AddScore(9.0); 
Console.WriteLine($"Рейтинг Эвереста после изменения: {everest.Rating}");

foreach (Movies movie in movieList) {
    if (movie.Name == "Эверест") {
        Console.WriteLine($"Рейтинг Эвереста, прочитанный из списка: {movie.Rating}");
    }
}