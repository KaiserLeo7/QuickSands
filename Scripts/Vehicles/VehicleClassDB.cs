using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class VehicleDB : MonoBehaviour {

        public List<Vehicle> vehicles = new List<Vehicle>();

        void Awake() {
            BuildVehicleDatabase();
        }

        void BuildVehicleDatabase() 
        {
            vehicles = new List<Vehicle>() {
                //  int maxHP, int currentHP, int speed, int partySize, int capacity, int price
                
                //NEXT TIME BALANCE THESE
                   new Scout(1000, 1000, 100, 2, 500, ),
                   new Trader(3000, 3000, 60, 3, 2500, ),
                   new Nomad(5000, 5000, 80, 4, 1000, ),
                   new Goliath(8000, 8000, 70, 5, 1500, )
            };
        }
        

        //get database
        public List<Vehicle> getVehicleList() {
            return vehicles;
        }

        //get vehicle at position
        public Vehicle getVehicle(int position) {
          return vehicles[position];
        }

        //clear
        public void clearVehicleList() {
            vehicles.Clear();
        }
    }
}
