using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.DataAccess
{
    public class PersonRepository
    {
        public async Task AddAsync(Person person)
        {

            using (var db = new PersonDbContext())
            {
              await db.People.AddAsync(person);
              await db.SaveChangesAsync();
            }
        }
    }
}
