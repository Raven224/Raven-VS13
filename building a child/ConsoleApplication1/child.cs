using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Child
    {
       public string name = "Robert";
       public DateTime dob = new DateTime(2010, 1, 3);
       
       public float joy = 0.2f;
       public float disgust = 0f;
       public float anger = 0.2f;
       public float fear = 0.2f;
       public float sadness = 0f;

       public void DisplayStatus()
       {
           TimeSpan age = DateTime.Now - dob;
           Console.WriteLine("{0} is {1} years old", name, (int)(age.TotalDays / 365));
           /*Console.WriteLine("there Joy is " + joy);
           Console.WriteLine("there discust is " + disgust);
           Console.WriteLine("there anger is " + anger);
           Console.WriteLine("there fear is " + fear);
           Console.WriteLine("there sadness is " + sadness);*/

       }
        public void DisplayHappyiness()
       {
           if (joy > 0.5f)
           {
               Console.WriteLine("supper happpy");
           }

           else (joy < 0.5f)
            {
                Console.WriteLine("sad");
            }
       }
    }
}
