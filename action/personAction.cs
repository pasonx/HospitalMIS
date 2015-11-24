using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PersonAction
    {
        public void add(Person p)
        {
            PersonDao personDao = new PersonDao();
            personDao.add(p);
        }

        public void update(Person p)
        {
            PersonDao personDao = new PersonDao();
            personDao.update(p);
        }
        public void delete(int id)
        {
            PersonDao personDao = new PersonDao();
            personDao.delete(id);
        }
        public List<Person> query()
        {
            PersonDao personDao = new PersonDao();
            return personDao.query();
        }
        public Person queryOne(int id)
        {
            PersonDao personDao = new PersonDao();
            return personDao.queryOne(id); 
        }
    }
}
