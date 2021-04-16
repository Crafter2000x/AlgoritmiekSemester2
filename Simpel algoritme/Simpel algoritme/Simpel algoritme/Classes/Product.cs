
namespace Simpel_algoritme.Classes
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name +" - "+ Price.ToString();;
        }
    }

    
}
