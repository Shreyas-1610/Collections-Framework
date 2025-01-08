namespace LambdaInClass
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = Person.getAll();

            //First query
            var topTwo = person.Where(e => e.Age < 60).Take(2).ToList();
            //foreach(var p in topTwo)
            //{
            //    Console.WriteLine($"SSN:{p.SSN} Name:{p.Name} Address:{p.Address} Age:{p.Age}");
            //}

            //13-18
            var ageBetween = person.Where(p => p.Age >= 13 && p.Age <= 18).ToList();
            //foreach (var p in ageBetween)
            //{
            //    Console.WriteLine($"SSN:{p.SSN} Name:{p.Name} Address:{p.Address} Age:{p.Age}");
            //}

            //Average
            var avgAge = person.Average(p => p.Age);
            //Console.WriteLine($"Average age is: {avgAge}");

            //countOccurence
            Problems problems = new Problems();
            var p = problems.count;
            //int countOcc = p.Sum(p=>p.Count(p=>p == 's'));
            //Console.WriteLine($"The character s appears {countOcc} times");

            //aggregate
            var a = problems.ints;
            var mini = a.Min();
            var maxi = a.Max();
            var avg = a.Average();
            var sum = a.Sum();
            //Console.WriteLine(sum);

            //starting with A
            var s = problems.strings;
            var start = s.Count(p=> p[0] == 'A');
            //Console.WriteLine(start);

            //top 3
            var takeThree = a.OrderByDescending(p=>p).Take(3);
            //foreach(var t  in takeThree)
            //{
            //    Console.WriteLine(t);
            //}

            //group by age
            var groupAge = People.GetPeoples().GroupBy(p => p.Age);
            //foreach(var group in groupAge)
            //{
            //    Console.WriteLine($"Age: {group.Key}");
            //    foreach (var peep in group)
            //    {
            //        Console.WriteLine($"{peep.Id}");
            //    }
            //}

            //price then name
            var Price = Product.GetProducts().Where(p => p.Price > 100).OrderBy(n => n.Name).ToList();
            foreach(var pp in Price)
            {
                Console.WriteLine($"{pp.Price} {pp.Name}");
            }
        }
    }
}
