using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch1;
namespace CrackingTheCodingInterview
{
    public class Run
    {
        private ChapterOne chapterOne;
        public Run()
        {
            chapterOne = new ChapterOne();
        }        

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Run run = new Run();

            var result = run.chapterOne.Test();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
