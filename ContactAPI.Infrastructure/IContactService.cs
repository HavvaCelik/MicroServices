using ContactAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAPI.Infrastructure
{
    public interface IContactService
    {
        public ContactDTO GetContactById(int Id);
    }
}
