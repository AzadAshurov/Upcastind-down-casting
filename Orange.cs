namespace Upcastind_down_casting
{
    internal class Orange : Fruit
    {
        private int VitaminC;
        public Orange(decimal price, string sort, int vitaminC) : base(price, sort)
        {
            VitaminC = vitaminC;
        }
        public override string Taste()
        {
            return "Very sour";
        }
        public override string ToString()
        {
            return base.ToString() + $"\nVitamin C: {VitaminC}";
        }
    }
}
