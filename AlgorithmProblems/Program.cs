namespace AlgorithmProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Problems!!!");
            Console.WriteLine("1.Bubble sort");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string[] name = { "Spiderman", "Batman", "Superman","Ironman","Antman"};
                    Bubblesort.StringArraySorting(name);
                    Console.WriteLine(string.Join(" ", name));
                    break;
                default: Console.WriteLine("Enter correct choice");
                    break;

            }
           
        }
    }
}