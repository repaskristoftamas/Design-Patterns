using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopy
{
    class Human
    {
        #region Fields
        private string name;
        public string Name
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

        private Human[] friends;
        public Human[] Friends
        {
            get { return friends; }
            set { friends = value; }
        }
        #endregion

        #region Constructors
        public Human() { }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Human(string name, int age, Human[] friends)
        {
            Name = name;
            Age = age;
            Friends = friends;
        }
        #endregion

        #region Methods
        public Human DeepCopy()
        {
            Human clone = new Human
            {
                Name = Name,
                Age = Age,
                Friends = Friends.Select(f => (Human)f.MemberwiseClone()).ToArray()
            };
            return clone;
        }
        public Human ShallowCopy()
        {
            Human clone = new Human(Name, Age, Friends);
            return clone;
        }
        public Human ShallowCopy2()
        {
            return (Human)MemberwiseClone();
        }
        #endregion
    }
}
