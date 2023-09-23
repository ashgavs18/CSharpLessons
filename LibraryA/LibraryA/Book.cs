namespace LibraryA
{
    public class Book
    {
        public String Title = String.Empty;
        public String Author=String.Empty;
        public String Genre=String.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public Book()
        {
            Console.WriteLine("Book is created");
        }
        public void OpenBook()
        {
            Console.WriteLine("Book is open");
        }
        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"Page No:{pageNo} BookMarked");
        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(0, 10);
        }

    }
}