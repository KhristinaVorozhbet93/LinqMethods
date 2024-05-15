namespace LinqMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Select
            var people = new List<Person>
            {
                new Person ("Tom", 23),
                new Person ("Bob", 27),
                new Person ("Sam", 29),
            };

            var names = people.SelectLazy(p => p.Name);
            people.Add(new Person("Alice", 24));

            foreach (string n in names)
                Console.WriteLine(n);

            Console.WriteLine("-------");

            //Where
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
          
            var source = list.WhereLazy(item => item % 2 == 0);
            list.Add(6);
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");

           
            //ToList
            var listSource = list.WhereLazy(item => item % 2 == 0).ToListMaterial();
            list.Add(8);
            foreach (var item in listSource)
            {
                Console.WriteLine(item);
            }
        }
    }
}

record class Person(string Name, int Age);
