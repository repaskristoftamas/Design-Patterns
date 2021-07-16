using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class AGreasyBread
    {
        #region Fields
        private string wrap;
        public string Wrap => wrap;

        private BreadType breadType;
        public BreadType BreadType => breadType;

        private double breadThickness;
        public double BreadThickness => breadThickness;

        private FatType fatType;
        public FatType FatType => fatType;

        private double fatQuantity;
        public double FatQuantity => FatQuantity;

        private double saltQuantity;
        public double SaltQuantity => saltQuantity;

        private OnionType onionType;
        public OnionType OnionType => onionType;

        private double onionQuantity;
        public double OnionQuantity => onionQuantity;
        #endregion

        #region Constructors
        public AGreasyBread() { }
        public AGreasyBread(BreadType breadType, double breadThickness, FatType fatType, double fatQuantity, double saltQuantity, OnionType onionType, double onionQuantity)
        {
            this.breadType = breadType;
            this.breadThickness = breadThickness;
            this.fatType = fatType;
            this.fatQuantity = fatQuantity;
            this.saltQuantity = saltQuantity;
            this.onionType = onionType;
            this.onionQuantity = onionQuantity;
        }
        #endregion

        #region Methods
        #endregion
    }
}
