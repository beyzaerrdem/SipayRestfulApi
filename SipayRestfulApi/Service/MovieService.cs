using SipayRestfulApi.Model;

namespace SipayRestfulApi.Service
{
    public class MovieService : IMovieService
    {
        public List<Movie> GetAll()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Id = 3,
                    Name = "Test",
                    Description = "Test",
                    Time = 0,
                    ImdbPoint = 0
                },
                new Movie()
                {
                    Id = 4,
                    Name = "Test",
                    Description = "Test",
                    Time = 0,
                    ImdbPoint = 0
                }
            };
        }

    }
}
