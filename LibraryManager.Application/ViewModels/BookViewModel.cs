namespace LibraryManager.Application.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(string title, string author, string isbn, int publicationDate)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            PublicationDate = publicationDate;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int PublicationDate { get; set; }
    }
}
