using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    abstract class LGOLEDTV
    {
        #region Fields
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private bool onSale;
        public bool OnSale
        {
            get { return onSale; }
            set { onSale = value; }
        }
        private Owner owner;
        public Owner Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        #endregion

        #region Constructors
        public LGOLEDTV() { }
        public LGOLEDTV(string name, int size, int price, bool onSale)
        {
            this.name = name;
            this.size = size;
            this.price = price;
            this.onSale = OnSale;
        }
        public LGOLEDTV(string name, int size, Owner owner)
        {
            this.name = name;
            this.size = size;
            this.owner = owner;
        }
        #endregion

        #region Methods
        public LGOLEDTV ShallowCopy()
        {
            return (LGOLEDTV)MemberwiseClone();
        }
        public abstract LGOLEDTV DeepCopy();
        #endregion
    }
}
