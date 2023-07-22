using Microsoft.AspNetCore.Mvc;
using SipayRestfulApi.Model;

namespace SipayRestfulApi.Extension
{
    public static class MovieExtension
    {
        public static IActionResult GetTimeMovie(this ControllerBase controller, string name)
        {
            var m = new Movies();
            var movie = m.MovieList.Where(x => x.Name == name).FirstOrDefault();
            if (movie == null)
            {
                return controller.StatusCode(404, "Not Found");
            }

            int minute = movie.Time;
            int hours = minute / 60;
            int remainderMinute = minute % 60;
            string time = string.Format("{0} saat {1} dakika", hours, remainderMinute);
            return controller.StatusCode(200, time);
        }
    }
}
