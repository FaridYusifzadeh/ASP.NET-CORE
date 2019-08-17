using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp.Models
{
    public static class Images
    {
        private static List<Image> images = new List<Image>
        {
            new Image {Id=1,Link="recent11.jpg"},
            new Image {Id=2,Link="recent12.jpg"},
            new Image {Id=3,Link="recent13.jpg"}
        };

        private static string[] students =
        {
            "Kenan",
            "Ilkin",
            "Gornboy",
            "Enushrevankisiliallahverdimashallah"
        };

        private static int[] numbers = { 1, 2, 3, 4, 5 };

        public static int[] GetNumbers() => numbers;

        public static string[] GetStudents() => students;

        public static List<Image> GetImages() => images;

    }

    public class Image
    {
        public int Id { get; set; }
        public string Link { get; set; }
    }
}
