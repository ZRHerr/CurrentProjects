using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    public class Ship
    {
        public Ship(string model)
        {
            if (model == "Volkswagon Creeper")
            {
                this.modelName = model;
                this.price = 1000;
                this.speed = 3.0;
                this.cargoCapacity = 100;
                this.tankCapacity = 10;
            }
            else if (model == "Church Van")
            {
                this.modelName = model;
                this.price = 2000;
                this.speed = 5.0;
                this.cargoCapacity = 300;
                this.tankCapacity = 15;
            }
            else if (model == "Ford F150")
            {
                this.modelName = model;
                this.price = 10000;
                this.speed = 7.5;
                this.cargoCapacity = 700;
                this.tankCapacity = 20;
            }
            else if (model == "Cadallac Escalade")
            {
                this.modelName = model;
                this.price = 20000;
                this.speed = 9.9;
                this.cargoCapacity = 1000;
                this.tankCapacity = 35;
            }
        }

        private string modelName;
        private double price;
        private double speed;
        private double tankCapacity;
        private int cargoCapacity;

        public string GetModelName() => modelName;
        public double GetPrice() => price;
        public double GetSpeed() => speed;
        public double GetTankCapacity() => tankCapacity;
        public int GetCargoCapacity() => cargoCapacity;

    }
}
