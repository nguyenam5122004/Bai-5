using Books.Models;

namespace Books.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
        Book GetBookById(int id);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}