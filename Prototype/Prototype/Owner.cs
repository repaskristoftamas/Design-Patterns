using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Owner
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
        private UseCase useCase;
        public UseCase UseCase
        {
            get { return useCase; }
            set { useCase = value; }
        }
        #endregion

        #region Constructors
        public Owner() { }
        public Owner(string name)
        {
            this.name = name;
        }
        public Owner(string name, int age)
            : this(name)
        {
            this.age = age;
        }
        public Owner(string name, int age, UseCase useCase)
            : this(name, age)
        {
            this.useCase = useCase;
        }
        #endregion

        #region Methods
        public Owner DeepCopy()
        {
            Owner clone = new Owner
            {
                name = name,
                age = age,
                useCase = useCase
            };
            return clone;
        }
        #endregion
    }
}
