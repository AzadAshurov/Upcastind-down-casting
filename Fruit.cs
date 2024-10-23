namespace Upcastind_down_casting
{
    internal abstract class Fruit
    {
        public decimal Price;
        public string Sort;
        public Fruit(decimal price, string sort)
        {
            Price = price;
            Sort = sort;
        }
        public abstract string Taste();
        public override string ToString()
        {
            return $"Fruit: {Sort} \nPrice: {Price}";
        }
    }
}
