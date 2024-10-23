namespace Upcastind_down_casting
{
    internal class Apple : Fruit
    {
        private int VitaminA;

        public int VitaminB;
        public Apple(decimal price, string sort, int vitaminA, int vitaminB) : base(price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }
        public override string Taste()
        {
            return "So cruchy and sweat";
        }
        public override string ToString()
        {
            return base.ToString() + $"\n Vitamin A: {VitaminA}\n Vitamin B: {VitaminB}";
        }

    }

}
