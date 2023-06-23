using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6_.NET
{
   
        public class Animal
        {
            public string name { get; set; }
            public int age { get; set; }

            public virtual void Speak()
            {
                Console.WriteLine("Make a sound");
            }
        }
    }

