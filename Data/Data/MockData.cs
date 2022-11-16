using Data.Models;
namespace Data.Mock
{
    public class MockData
    {
        public static List<Models.Monitor> GetMonitors()
        {
            return new List<Models.Monitor>()
            {
                new Models.Monitor()
                {
                    Id = 1,
                    Name = "Sceptre",
                    ScreenSize = 24,
                    Display = "1920 x 1080",
                    Refresh = 60,
                    Price = 129.97,
                    ImgLink = "https://m.media-amazon.com/images/I/71rXSVqET9L._AC_SX450_.jpg",
                    MatrixId = 1
                },
                new Models.Monitor()
                {
                    Id = 2,
                    Name = "Acer",
                    ScreenSize = 21.5,
                    Display = "1920 x 1080",
                    Refresh = 75,
                    Price = 129.99,
                    ImgLink = "https://m.media-amazon.com/images/I/81QpkIctqPL._AC_SY450_.jpg",
                    MatrixId = 2
                },
                new Models.Monitor()
                {
                    Id = 3,
                    Name = "LG",
                    ScreenSize = 24,
                    Display = "1920 x 1080",
                    Refresh = 60,
                    Price = 129.97,
                    ImgLink = "https://m.media-amazon.com/images/I/81WrBJdJcIL._AC_SX522_.jpg",
                    MatrixId = 3
                },
                new Models.Monitor()
                {
                    Id = 4,
                    Name = "Sceptre",
                    ScreenSize = 24,
                    Display = "1920 x 1080",
                    Refresh = 60,
                    Price = 129.97,
                    ImgLink = "https://m.media-amazon.com/images/I/81j9OvhbxbL._AC_SY450_.jpg",
                    MatrixId = 4
                },
            };
        }

        public static List<Matrix> GetMatrix()
        {
            return new List<Matrix>()
            {
                new Matrix()
                {
                    Id = 1,
                    Name = "LED"
                },
                new Matrix()
                {
                    Id = 2,
                    Name = "IPS"
                },
                new Matrix()
                {
                    Id = 3,
                    Name = "TFT"
                },
                new Matrix()
                {
                    Id = 4,
                    Name = "OLED"
                },
            };
        }
    }
}
