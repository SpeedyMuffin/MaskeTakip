using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> Getlist()
        {
            return null;
        }
        public bool checkPerson (Person person)
        {
            return true;
        }
    }
}
