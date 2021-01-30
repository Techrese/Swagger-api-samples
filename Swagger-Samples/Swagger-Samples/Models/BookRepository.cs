using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Swagger_Samples.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }        


        public void AddBook(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
        }        

        public IEnumerable<Book> Find(Expression<Func<Book, bool>> predicate)
        {
            var query = _context.Books.AsNoTracking().Where(predicate);

            if (query == null)
                throw new NullReferenceException("What you searched for was not found in the database");

            return query;
        }

        public IEnumerable<Book> GetAll()
        {
            var query = _context.Books.ToList();
            return query;
        }

        public Book GetById(Guid id)
        {
            var query = _context.Books.AsNoTracking().SingleOrDefault(b => b.Book_Id == id);
            if (query == null)
                throw new NullReferenceException("Book was not found in database!");

            return query;
        }

        public void RemoveBook(Guid id)
        {
            var query = _context.Books.AsNoTracking().SingleOrDefault(b => b.Book_Id == id);

            if (query == null)
                throw new NullReferenceException("Give Id was not found in the database!");

            _context.Remove(query);
            _context.SaveChanges();

        }
    }
}
