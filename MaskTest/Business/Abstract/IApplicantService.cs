using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public internal interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> Getlist();

        bool checkPerson(Person person);
    }
}
