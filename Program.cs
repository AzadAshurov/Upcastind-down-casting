using System.Reflection;

namespace Upcastind_down_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(100, "Qizil Ahmed", 30, 45);
            Orange orange = new Orange(100, "Afro-american orange", 999);
            Pineapple pineapple = new Pineapple(150, "Antarctida sort", 100, 234);
            Fruit[] fruits = new Fruit[] { orange, apple, pineapple };
            foreach (var fruit in fruits)
            {
                var type = fruit.GetType();
                Console.WriteLine(type.Name);


                //it can see only public fields
                //var fields = type.GetFields();




                //Allah gorusun microsoftun dokumentasiyasini
                FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);



                foreach (var field in fields)
                {
                    //Console.WriteLine(field.Name);
                    var fieldsValue = field.GetValue(fruit);
                    Console.WriteLine($"{field.Name} {fieldsValue}");
                }


                Console.WriteLine("-------------------------------------");
            }



        }
    }
}
