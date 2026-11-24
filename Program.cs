
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region point 1,2,3,4
            Book book = new Book();
            // Console.WriteLine(book.password); 
            //compile time error لانها متعرفه برايفت والبرايفت بتشنغل جوا الكلاس بتاعها بس 
            Console.WriteLine(book.copiesInStock);
            // هتشتغل عشان  بيشتغل جوا نفس البروجيكت internal 
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Genre);
            #endregion
            #region point 4
            Genre genre = Genre.Fiction;
            int x = (int)genre;
            Genre genre2 = Genre.NonFiction;
            int y = (int)genre2;
            Genre genre3 = Genre.Science;
            int z = (int)genre3;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
           // Console.WriteLine((int)Genre.NonFiction);
            #endregion
            #region point 5
            int genreNumber = 1;
            Genre gener4 =(Genre) genreNumber;
            Console.WriteLine(gener4);
            #endregion
            #region point 6
            Genre genre5 = Genre.Fiction;
            string TranslateToString = genre5.ToString();
            Console.WriteLine(TranslateToString);
            #endregion
            #region point 7
            string genreText = "Science";
            Genre genre6 =(Genre) Enum.Parse(typeof(Genre),genreText);
            Console.WriteLine(genre6);
            #endregion
            #region point 8
            string genreText1 = "Mystery";
            Genre genre7;
           bool parsed= Enum.TryParse<Genre>( genreText1, out  genre7);
            if (parsed == false)
            {
                Console.WriteLine("Unknown genre");
            }
            else Console.WriteLine(genre7);
            #endregion
        }
    }
}
