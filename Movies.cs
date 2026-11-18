public class Movies {
    public string Name;
    public int Year;
    public string Genre;
    public double Rating;

    public Movies(string name, string genre, int year, double rating) {
        Name = name;
        Year = year;
        Genre = genre;
        Rating = rating;
    }

     public void AddScore(double score) {
        if (score < 0 || score > 10) {
            return;
        }

        Rating = (Rating + score) / 2;
    }
}