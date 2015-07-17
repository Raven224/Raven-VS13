using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {

        
        public void run()
        {

        Child child1 = new Child();
        Child child2 = new Child();

        child1.name = ("Rob");

        child2.name = ("Jan");

        


        child1.DisplayStatus();
        child2.DisplayStatus();
        child1.DisplayHappyiness();
        child2.DisplayHappyiness();

        
            
        Console.WriteLine("Running the game");
        }
    }
}
