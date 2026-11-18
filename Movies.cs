public class Movies {
    private string _name = "Безымянный фильм";

    public string Name {
        get {
            return _name;
        }

        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _name = "Безымянный фильм";
                return;
            }

            _name = value.Trim();
        }
    }

    public int Year;
    public string Genre;
    public double Rating { get; private set; }

    public Movies(string name, string genre, int year, double rating) {
        Name = name;
        Year = year;
        Genre = genre;
        Rating = rating;

        if (Rating < 0) {
            Rating = 0;
        }

        if (Rating > 10) {
            Rating = 10;
        }
    }

     public void AddScore(double score) {
        if (score < 0 || score > 10) {
            return;
        }

        Rating = (Rating + score) / 2;

        if (Rating < 0) {
            Rating = 0;
        }

        if (Rating > 10) {
            Rating = 10;
        }
    }
}