using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public static class VehicleDB {

        public static List<Vehicle> vehicles = new List<Vehicle>();


        static VehicleDB() 
        {
            vehicles = new List<Vehicle>() {
                // int id, int maxHP, int currentHP, int speed, int partySize, int capacity, int price
                
                //NEXT TIME BALANCE THESE
                   new Scout(1, 1000, 1000, 100, 2, 500, 3000),
                   new Trader(2, 3000, 3000, 60, 3, 2500, 7000),
                   new Nomad(3, 5000, 5000, 80, 4, 1000, 15000),
                   new Goliath(4, 8000, 8000, 70, 5, 1500, 30000)
            };
        }
        

        //get database
        public static List<Vehicle> getVehicleList() {
            return vehicles;
        }

        //get vehicle at position
        public static Vehicle getVehicle(int position) {
          return vehicles[position];
        }

        //clear
        public static void clearVehicleList() {
            vehicles.Clear();
        }
    }
}
