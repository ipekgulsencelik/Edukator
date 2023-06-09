﻿using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EFContactDAL : GenericRepository<Contact>, IContactDAL
    {
        public List<Contact> GetLastFourMessage()
        {
            using var context = new Context();

            var values = context.Contacts.OrderByDescending(x => x.ContactID).Take(4).ToList();

            return values;
        }
    }
}
