namespace PaymantsApp
{
    public static class Homeworks
    {


        public static void L3(string[] args) => Console.WriteLine($"Witaj! {args[0]}");

        public static void L4()
        {
            int intX = 5;
            int intY = 2;
            // int intResult;

            long longX = Int32.MaxValue;
            long longY = 36;
            // long longResult;

            float floatX = 10.5f;
            float floatY = 2f;
            // float floatResult;

            double doubleX=20.5;
            double doubleY=5;
            // double doubleResult;
            
            decimal decimalX=100.0m;
            decimal decimalY=50.484m;
            // decimal decimalResult;

            string str="macior";

            System.Console.WriteLine($"{intX} + {intY} = {intX+intY}\n");
            System.Console.WriteLine($"{longX} - {floatY} = {longX-floatY}\n");
            System.Console.WriteLine($"{floatX} / {intY} = {floatX/intY}\n");
            System.Console.WriteLine($"{doubleX} * {longY} = {doubleX*longY}\n");
            System.Console.WriteLine($"{decimalX} / {decimalY} = {decimalX/decimalY}\n");
            System.Console.WriteLine($" 5 / 3 = {5/3} (Reszta: {5%3})\n");
            System.Console.WriteLine($"{str} + {intX} = {str+intX}");

        }

        public static void L5()
        {
            List<string> employes = new List<string>
            {
              "Mac", "Gosia"
            };

            List<int> numbers = new List<int>
            {1,2,3};

            foreach (var emp in employes)
            {
                System.Console.WriteLine(emp);
                foreach (var num in numbers)
                {
                    System.Console.WriteLine(num);
                }
            }


        }


    }
}