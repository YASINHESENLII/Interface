namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Student student1 = new Student("Yasin", "Hesenli");
            
            Console.WriteLine(student1.CodeEmail); 

            Student student2 = new Student("Hakim", "Dugi");
            
            Console.WriteLine(student2.CodeEmail);
        }
    }
}