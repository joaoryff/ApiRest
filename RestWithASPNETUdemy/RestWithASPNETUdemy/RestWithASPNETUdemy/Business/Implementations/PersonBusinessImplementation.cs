using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        //private volatile int count;
        private IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }
        public List<Person> FindAll()
        {
            //List<Person> persons = new List<Person>();
            //for (int i = 0; i < 8; i++)
            //{
            //    Person person = MockPerson(i);
            //    persons.Add(person);
            //}
            return _repository.FindAll();
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
            //return _repository.Person.SingleOrDefault(p => p.Id.Equals(id));
            return _repository.FindByID(id);
        }
        public Person Create(Person person)
        {
            //try
            //{
            //    _repository.Add(person);
            //    _repository.SaveChanges();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //return person;

            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            //var result = _repository.Person.SingleOrDefault(p => p.Id.Equals(id));
            //if (result != null)
            //{

            //    try
            //    {

            //        _repository.Person.Remove(result);
            //        _repository.SaveChanges();
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}

            _repository.Delete(id);
        }



        public Person Update(Person person)
        {
            //if (!Exists(person.Id)) return new Person();

            //var result = _repository.Person.SingleOrDefault(p => p.Id.Equals(person.Id));
            //{
            //    if (result != null)
            //    {

            //        try
            //        {
            //            //_context.Add(person);
            //            _repository.Entry(result).CurrentValues.SetValues(person);
            //            _repository.SaveChanges();
            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }
            //    }
            //    return person;
            //}
            return _repository.Update(person);
        }

        //private bool Exists(long id)
        //{
        //    return _repository.Person.Any(p => p.Id.Equals(id));
        //}

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
