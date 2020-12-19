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
                //  int damage, double critDamage, int maxHP, int currentHP
                //string name, int health, int armour, double speed, int buttspace, int damage, double weight) : base(name, health, armour, speed, buttspace, damage, weight
                   new Scout( ),
                   new Trader(  ),
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
