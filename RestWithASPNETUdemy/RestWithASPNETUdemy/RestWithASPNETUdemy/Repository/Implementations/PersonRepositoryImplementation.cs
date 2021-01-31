using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    {
        //private volatile int count;
        private MySQLContext _context;

        public PersonRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }
        public List<Person> FindAll()
        {
            //List<Person> persons = new List<Person>();
            //for (int i = 0; i < 8; i++)
            //{
            //    Person person = MockPerson(i);
            //    persons.Add(person);
            //}
            return _context.Person.ToList();
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
            return _context.Person.SingleOrDefault(p => p.Id.Equals(id));
        }
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Person.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {

                try
                {

                    _context.Person.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }



        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return null;

            var result = _context.Person.SingleOrDefault(p => p.Id.Equals(person.Id));
            {
                if (result != null)
                {

                    try
                    {
                        //_context.Add(person);
                        _context.Entry(result).CurrentValues.SetValues(person);
                        _context.SaveChanges();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                return person;
            }

        }

        public bool Exists(long id)
        {
            return _context.Person.Any(p => p.Id.Equals(id));
        }


        //private Person MockPerson(int i)
        //{
        //    return new Person
        //    {
        //        Id = 1,
        //        FirstName = "Person Name" + i,
        //        LastName = "Person Name" + i,
        //        Address = " Some Address" + i,
        //        Gender = "Male"
        //    };
        //}

        //private long IncrementAndGet()
        //{
        //    return Interlocked.Increment(ref count);
        //}
    }
}
