using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.run();
        }

        public void run()
        {
            
            ClubMember c1 = new ClubMember();
            c1.Nr = 1;
            c1.Fname = "Jens";

            ClubMember c2 = new ClubMember();
            c2.Nr = 2;
            c2.Fname = "Peter";
            c2.Lname = "petersen";
            c2.Age = 25;

            ClubMember c3 = new ClubMember();
            c3.Nr = 3;
            c3.Fname = "hans";
            c3.Lname = "nielsen";
            c3.Age = 35;

            MyList ml = new MyList();
            ml.Insert(c1,1);
            ml.Insert(c2,2);
            ml.Insert(c3,3);

            Console.Write(ml.ToString());
            Console.ReadLine();
        }
    }
}
