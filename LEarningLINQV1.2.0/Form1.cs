using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEarningLINQV1._2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
            {
                listOfNumbers.Add(random.Next(100));
            }
            Console.WriteLine("Na liście znajduje się {0} liczb", listOfNumbers.Count()); //we can operate on current list right before showing result.
            Console.WriteLine("Najmniejsza z nich to {0}", listOfNumbers.Min());
            Console.WriteLine("Największa z nich to {0}", listOfNumbers.Max());
            Console.WriteLine("Ich suma wynosi {0}", listOfNumbers.Sum());
            Console.WriteLine("Natomiast ich średnia to {0} ", listOfNumbers.Average());

            var under50sorted = from number in listOfNumbers
                where number < 50
                orderby number descending
                select number;

            List<int> newList = under50sorted.ToList(); // So we took numbers below 50 and sorted them descending

            var firstFive = under50sorted.Take(5);

            List<int> shortList = firstFive.ToList(); //Taking first five from the bigger list to shorter one.
            foreach (int n in shortList)
            {
                Console.WriteLine("Oto liczba nr:"+ n);
            }
            //These are just a few examples how to use LINQ, for more you can visit  https://code.msdn.microsoft.com/101-LINq-samples-3fb9811b

        }
    }
}
