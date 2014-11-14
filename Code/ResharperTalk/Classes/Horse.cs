using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ResharperTalk.Abstractions;

namespace ResharperTalk.Classes
{
    public class Horse : IVehicle
    {
        private readonly Rider _rider;

        public IFuelSource FuelSource { get; set; }

        public Horse(IFuelSource fuelSource)
        {
            FuelSource = fuelSource;
            _rider = new Rider();
        }

        public void Alert()
        {
            throw new NotImplementedException();
        }

        public void SetSpeed(int speed)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public int TopSpeed
        {
            get { return 0; }
            set { throw new NotImplementedException(); }
        }

        
    }
}