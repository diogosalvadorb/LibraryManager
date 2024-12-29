using Microsoft.VisualBasic;

namespace LibraryManager.Application.ViewModels
{
    public class LoanViewModel
    {
        public LoanViewModel(int bookId, int userId, DateTime? loanDate, DateTime? returnDate, DateTime? dueDate)
        {
            BookId = bookId;
            UserId = userId;
            LoanDate = loanDate;
            ReturnDate = returnDate;
            DueDate = dueDate;
        }

        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
