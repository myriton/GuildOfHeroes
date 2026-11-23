public static class Probe {
    public static void Run() {
    Console.WriteLine(">>> Проба <<<");

    Guild emptyGuild = new Guild("Пустая гильдия");

    Hero? nobody = emptyGuild.FindStrongest();
    Console.WriteLine($"FindStrongest на пустой == null: {nobody == null}");
    Console.WriteLine($"CountHealthy(0) на пустой: {emptyGuild.CountHealthy(0)}");

    emptyGuild.AddHero(new Hero("Слабый", 50));
    emptyGuild.AddHero(new Hero("Сильный", 150));
    emptyGuild.AddHero(new Hero("Ровно 120", 120));

    Hero? strongest = emptyGuild.FindStrongest();
    if (strongest != null) {
        Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
    }
}





}


    



