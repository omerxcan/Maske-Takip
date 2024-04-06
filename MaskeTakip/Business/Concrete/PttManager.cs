using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IPersonService _personService;
        public PttManager(IPersonService personService)
        {
            _personService = personService; 
            
        }
        public void GiveMask(Person person)
        {
            if(_personService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi");
            }
        }
    }
}
