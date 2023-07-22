using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblem
{
    public class Program
    {
        public static void Main()
        {
            int N = 5; // Total number of chapters in the book
            int K = 15; // Current reading page

            // Create an array of chapters with start and end pages
            Chapter[] chapters = new Chapter[]
            {
            new Chapter { StartPage = 1, EndPage = 4 },
            new Chapter { StartPage = 6, EndPage = 10 },
            new Chapter { StartPage = 12, EndPage = 18 },
            new Chapter { StartPage = 21, EndPage = 25 },
            new Chapter { StartPage = 27, EndPage = 32 }
            };

            int chaptersYetToRead = FindChaptersToRead(N, chapters, K);
            Console.WriteLine("Number of chapters yet to read: " + chaptersYetToRead);
        }

        public static int FindChaptersToRead(int N, Chapter[] chapters, int K)
        {
            int currentChapter = 0;
            int chaptersYetToRead = 0;

            // Find the current chapter Amelia is reading
            for (int i = 0; i < N; i++)
            {
                if (K >= chapters[i].StartPage && K <= chapters[i].EndPage)
                {
                    currentChapter = i + 1;
                    break;
                }
            }

            // Calculate the total number of chapters yet to read
            chaptersYetToRead = N - currentChapter + 1;

            return chaptersYetToRead;
        }
    }
}
