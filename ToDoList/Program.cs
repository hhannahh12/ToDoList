using System;
using ToDoList.Services;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing");
            var a = new MenuService();
            a.Run();
        }
    }
}
