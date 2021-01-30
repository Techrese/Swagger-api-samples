using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Swagger_Samples.Models
{
    public interface IBookRepository
    {
        Book GetById(Guid id);
        IEnumerable<Book> GetAll();

        void AddBook(Book book);
        void RemoveBook(Guid id);

        IEnumerable<Book> Find(Expression<Func<Book, bool>> predicate);

    }
}
