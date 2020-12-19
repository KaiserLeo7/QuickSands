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
                
                   new Scout( ),
                   new Trader( ),
                   new Nomad( ),
                   new Goliath( )
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
