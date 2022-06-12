using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDp
{
    public class Video : LibraryItem
    {
        private string director { get; set; }
        private string title { get; set; }
        private int playTime { get; set; }

        public Video(string director, string title, int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            this.NumCopies = numCopies;
            this.playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("Video ----- ");
            Console.WriteLine(" Director: {0}", director);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", playTime);
        }
    }
}
