using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelsManager
{
    public class ContactManager : IContactService
    {
        private readonly IRepositoryManager _manager;

        public ContactManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateContact(Contact contact)
        {
            _manager.Contact.CreateContact(contact);
            _manager.Save();
        }
    }
}
