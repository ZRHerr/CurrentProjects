using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    public class Planet
    {
        public Planet(string name, double[] coordinates, double multiplier)
        {
            this.name = name;
            this.coordinates = coordinates;
            this.multiplier = multiplier;
        }

        private string name;
        private double[] coordinates = new double[2];
        private double multiplier;

        public string GetName() => this.name;
        public void SetName(string name) => this.name = name;

        public double[] GetCoordinates() => this.coordinates;
        public void SetCoordinates(double[] coordinates) => this.coordinates = coordinates;

        public double GetMultiplier() => this.multiplier;
        public void SetMultiplier(double multiplier) => this.multiplier = multiplier;
    }
}
