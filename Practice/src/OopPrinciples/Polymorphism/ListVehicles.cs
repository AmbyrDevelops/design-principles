using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Polymorphism {
    public class ListVehicles : PolyVehicle{
        private List<PolyVehicle> vehicles = new List<PolyVehicle>();

        public ListVehicles() {
        }
        
        public void AddVehicle(PolyVehicle vehicle) {
            this.vehicles.Add(vehicle);
        }

        public void ListAllVehicles() {
            foreach (var vehicle in vehicles) {
                vehicle.Start();
                vehicle.Brake();
                vehicle.Accelerate();
                vehicle.Stop();
            }
        }
    }
}