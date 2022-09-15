using DeweyDecimalLibrary.LinkedList;
using DeweyDecimalLibrary.Models;

namespace DeweyDecimalLibrary.Logic
{
    public class ReplacingTheBooks
    {
        #region Generate Game Call Numbers
        public List<string> GenerateCallNos()
        {
            string period = "";
            Random rnd = new Random();
            CLinkedList<BookModel> books = new CLinkedList<BookModel>();
            List<string> callnums = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                //generate a random number 1 >= n <= 999
                int number = rnd.Next(1, 1000);

                //generate a random number between 1 and 10
                int pCheck = rnd.Next(1, 11);

                if (pCheck > 8) { period = $".{rnd.Next(1, 1000)}"; }

                string author = RandomString(3);

                BookModel b = new BookModel($"{number.ToString().PadLeft(3, '0')}{period} {author}");

                books.Append(b);
            }

            books.QuickSort(books.Head);

            foreach (BookModel book in books)
            {
                callnums.Add(book.CallNumber);
            }

            return callnums;
        }
        #endregion

        #region Generate Random String
        public string RandomString(int size)
        {
            Random rnd = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return new string(Enumerable.Repeat(chars, size).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        #endregion

        #region Shuffle List

        public List<string> ShuffleList(List<string> myList)
        {
            Random rnd = new Random();

            return myList.OrderBy(item => rnd.Next()).ToList();
        }
        #endregion
    }
}
