using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    public class Items
    {
        public Items(string name, double price, int abundance)
        {
            this.name = name;
            this.price = price;
            this.abundance = abundance;
        }

        private string name;
        private double price;
        private int abundance;

        public string GetName() => this.name;
        public double GetPrice() => this.price;
        public int GetAbundance() => this.abundance;

    }
}
