using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Services
{
    class MenuService
    { 
        public void Run()
        {
            Console.WriteLine("Hello {0}\n", Environment.UserName);
            Console.WriteLine("Please select from the following... \n1: Add Item\n2: View Item\n3: Edit Item\n4: Delete Item");
            var answer = Console.ReadLine();
        }
    }
}
