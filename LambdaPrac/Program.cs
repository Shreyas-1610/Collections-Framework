namespace LambdaPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //select
            var Method = Employee.GetAllEmployees().ToList();
            var Query = (from emp in Employee.GetAllEmployees() select emp).ToList();

            //foreach (var emp in Query) 
            //{
            //    Console.WriteLine($"ID:{emp.Id} Name:{emp.Name}");
            //}

            //where
            var MethodWhere = Employee.GetAllEmployees().Where(where => where.Salary > 30).ToList();
            var QueryWhere = (from emp in Employee.GetAllEmployees() where emp.Salary > 30 select emp).ToList();

            //foreach( var emp in QueryWhere)
            //{
            //    Console.WriteLine($"Id:{emp.Id} Name: {emp.Name} Salary: {emp.Salary}");
            //}

            //distinct
            var MethodDist = Employee.GetAllEmployees().Select(emp=> emp.Dept).Distinct().ToList();
            var QueryDist = (from emp in Employee.GetAllEmployees() select emp.Dept).Distinct().ToList();
            //foreach(var emp in QueryDist)
            //{
            //    Console.WriteLine(emp);
            //}

            //contains
            var MethodCont = Employee.GetAllEmployees().Where(emp => emp.Name.Contains("ABC"));
            var QueryCont = (from emp in Employee.GetAllEmployees() where (emp.Name.Contains("ABC")) select emp);
            //foreach(var emp in QueryCont)
            //{
            //    Console.WriteLine($"Id: {emp.Id} Dept = {emp.Dept}");
            //}

            //single
            var MethodSingle = Employee.GetAllEmployees().Single(emp => emp.Dept == "HR");
            //Console.WriteLine($"Id: {MethodSingle.Id} Name: {MethodSingle.Name}");

            //First
            var MethodFirst = Employee.GetAllEmployees().First(x=>x.Id == 2);
            var QueryFirst = (from emp in Employee.GetAllEmployees() select emp).First();
            //Console.WriteLine($"name: {MethodFirst.Name}");

            //last
            var MethodLast = Employee.GetAllEmployees().Last(x => x.Dept == "Sales");
            var QueryLast = (from emp in Employee.GetAllEmployees() select emp).Last(x=> x.Dept =="IT");
            //Console.WriteLine($"Id: {QueryLast.Id} name: {QueryLast.Name}");

            //any
            var MethodAny = Employee.GetAllEmployees().Any(x => x.Salary > 50 && x.Dept=="HR");
            //if (MethodAny)
            //{
            //    Console.WriteLine("Atleast 1 emp have salary > 20");
            //}
            //else
            //{
            //    Console.WriteLine("No one is richer");
            //}

            //orderby
            var MethodOrder = Employee.GetAllEmployees().OrderBy(x => x.Salary).ToList();
            var QueryOrder = (from emp in Employee.GetAllEmployees() orderby emp.Salary select emp).ToList();
            //foreach(var emp in QueryOrder)
            //{
            //    Console.WriteLine($"Salary:{emp.Salary}");
            //}

            //orderBy Desc
            var MethodOrderDesc = Employee.GetAllEmployees().OrderByDescending(x => x.Salary).ToList();
            var QueryOrderDesc = (from emp in Employee.GetAllEmployees() orderby emp.Salary descending select emp).ToList();
            //foreach (var emp in QueryOrderDesc)
            //{
            //    Console.WriteLine($"Salary:{emp.Salary}");
            //}

            //then
            var MethodThen = Employee.GetAllEmployees().OrderBy(x => x.Dept).ThenBy(x=>x.Name).ToList();
            var QueryThen = (from emp in Employee.GetAllEmployees() orderby emp.Dept, emp.Name select emp).ToList();
            //foreach(var emp in QueryThen)
            //{
            //    Console.WriteLine($"Dept:{emp.Dept} Name:{emp.Name}");
            //}

            //reverse
            var MethodRev = Employee.GetAllEmployees().Select(x=> x.Name).Reverse().ToList();
            var QueryRev = (from emp in Employee.GetAllEmployees() select emp.Salary).Reverse().ToList();
            //foreach(var emp in QueryRev)
            //{
            //    Console.WriteLine(emp);
            //}

            //avg
            var MethodSyntaxAvgValue = Employee.GetAllEmployees().Average(emp => emp.Salary);  
            var QuerySyntaxAvgValue = (from emp in Employee.GetAllEmployees() select emp).Average(e => e.Salary);

            //Console.WriteLine($"Method Syntax Average Value = {MethodSyntaxAvgValue}");
            //Console.WriteLine($"Query Syntax Average Value = {QuerySyntaxAvgValue}");


            //min-max
            var MethodSyntaxMax = Employee.GetAllEmployees().Max(i => i.Salary);
            var MethodSyntaxMin = Employee.GetAllEmployees().Min(i => i.Salary);
            var QuerySyntaxMax = (from emp in Employee.GetAllEmployees() select emp).Max(i => i.Salary);
            var QuerySyntaxMin = (from emp in Employee.GetAllEmployees() select emp).Min(emp => emp.Salary);

            Console.WriteLine($"Highest Salary by Method:{MethodSyntaxMax}");
            Console.WriteLine($"Lowest Salary by Method:{MethodSyntaxMin}");

            Console.WriteLine($"Highest Salary by Query:{QuerySyntaxMax}");
            Console.WriteLine($"Lowest Salary by Query:{QuerySyntaxMin}");
        }
    }
}
