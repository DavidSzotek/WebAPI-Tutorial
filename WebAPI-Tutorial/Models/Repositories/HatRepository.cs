using WebApplication1.Models;

namespace WebAPI_Tutorial.Models.Repositories
{
    public static class HatRepository
    {
        private static List<Hat> hats = new List<Hat>()
        {
            new Hat{HatId=1, Brand = "Nike", Color = "Black", Gender = "Men", Price = 639, Size = 42},
            new Hat{HatId=2, Brand = "Adidas", Color = "Brown", Gender = "Women", Price = 799, Size = 42},
            new Hat{HatId=3, Brand = "Puma", Color = "White", Gender = "Women", Price = 1199, Size = 42},
            new Hat{HatId=4, Brand = "FILA", Color = "Blue", Gender = "Men", Price = 599, Size = 42}
        };

        public static bool HatExists(int id)
        {
            return hats.Any(x => x.HatId == id);
        }

        public static Hat? GetHatById(int id)
        {
            return hats.FirstOrDefault(x=>x.HatId == id);
        }
    }
}
