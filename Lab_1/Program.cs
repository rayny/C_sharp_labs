/*Lab_1, Author: Sergey Bronskiy*/

using System; 
namespace Lab_1
{
    class Program
    {
        static void Main(string[] args) 
        {
            foreach (object a in args)
            {
                Console.WriteLine("ARG1:"+a);
            }
        }
    }
}
