using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Person
    {
        public Person()
        {

        }
        public Person(int _id,String _name,int _age,String _desc)
        {
            id = _id;
            name = _name;
            age = _age;
            desc = _desc;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private String desc;

        public String Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private String medicine;

        public String Medicine
        {
            get { return medicine; }
            set { medicine = value; }
        }

    }
}
