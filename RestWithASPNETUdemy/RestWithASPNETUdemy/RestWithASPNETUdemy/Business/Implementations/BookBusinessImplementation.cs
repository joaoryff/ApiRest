using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Bussines.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        //private volatile int count;
        private MySQLContext _repository;

        public BookBusinessImplementation(MySQLContext repository)
        {
            _repository = repository;
        }
        public List<Book> FindAll()
        {
            //List<Person> persons = new List<Person>();
            //for (int i = 0; i < 8; i++)
            //{
            //    Person person = MockPerson(i);
            //    persons.Add(person);
            //}
            return _repository.Book.ToList();
        }


        public Person FindByID(long id)
        {
            //return new Person
            //{
            //    Id = 1,
            //    FirstName = "Joao",
            //    LastName = "Ryff",
            //    Address = " Montreal - Quebec - Canada",
            //    Gender = "Male"
            //};
            return _repository.Book.SingleOrDefault(p => p.Id.Equals(id));
        }
        public Book Create(Book book)
        {
            try
            {
                _repository.Add(book);
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return book;
        }

        public void Delete(long id)
        {
            var result = _repository.Book.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {

                try
                {

                    _repository.Book.Remove(result);
                    _repository.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }



        public Book Update(Book book)
        {
            if (!Exists(book.Id)) return null;

            var result = _repository.Book.SingleOrDefault(p => p.Id.Equals(book.Id));
            {
                if (result != null)
                {

                    try
                    {
                        //_context.Add(person);
                        _repository.Entry(result).CurrentValues.SetValues(book);
                        _repository.SaveChanges();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                return book;
            }

        }

        public bool Exists(long id)
        {
            return _repository.Book.Any(p => p.Id.Equals(id));
        }






    }
}
