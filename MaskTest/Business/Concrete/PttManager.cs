using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
       
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (personManager.checkPerson(person)) ;
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }
        }

    }
}
