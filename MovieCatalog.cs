public class MovieCatalog {
    private List<Movies> _movies = new List<Movies>();

    public int MovieCount {
        get { return _movies.Count; }
    }

    public bool AddMovie(Movies movie) {
        if (FindMovieByName(movie.Name) != null) {
            return false; 
        }
        _movies.Add(movie);
        return true;
    }

    public Movies? FindMovieByName(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        string searchName = name.Trim();

        foreach (Movies movie in _movies) {
            if (string.Equals(movie.Name, searchName, StringComparison.OrdinalIgnoreCase)) {
                return movie;
            }
        }
        return null;
    }

    public bool RemoveMovie(string name) {
        Movies? movie = FindMovieByName(name);
        if (movie == null) {
            return false;
        }
        return _movies.Remove(movie);
    }

    public List<Movies> GetMovies() {
        List<Movies> result = new List<Movies>();
        foreach (Movies movie in _movies) {
            result.Add(movie);
        }
        return result;
    }

    public int CountHighlyRated(double minimumRating) {
        int count = 0;
        foreach (Movies movie in _movies) {
            if (movie.Rating >= minimumRating) {
                count++;
            }
        }
        return count;
    }
}