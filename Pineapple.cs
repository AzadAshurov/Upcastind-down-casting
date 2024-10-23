namespace Upcastind_down_casting
{
    internal class Pineapple : Fruit
    {
        private int VitaminE;
        public int VitaminD;

        public Pineapple(decimal price, string sort, int vitaminE, int vitaminD) : base(price, sort)
        {
            VitaminE = vitaminE;
            VitaminD = vitaminD;
        }
        public override string Taste()
        {
            return "mmmm tasty,so sweet";
        }
        public override string ToString()
        {
            return base.ToString() + $"\nVitamin E: {VitaminE}\nVitamin D: {VitaminD}";
        }
    }
}
