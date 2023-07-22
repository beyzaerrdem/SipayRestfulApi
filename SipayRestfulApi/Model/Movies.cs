namespace SipayRestfulApi.Model
{
    public class Movies
    {
        public List<Movie> MovieList { get; set; }

        public Movies()
        {
            MovieList = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Name = "Titanik",
                    Description = "Film",
                    Time = 100,

                    ImdbPoint = 9
                },
                new Movie()
                {
                    Id = 2,
                    Name = "Glass",
                    Description = "Film",
                    Time = 120,
                    ImdbPoint = 8
                }
            };
        }
    }
}
