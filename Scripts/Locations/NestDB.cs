using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class NestDB {

        private static List<Nest> nests = new List<Nest>();

        void Start() {
            BuildClassDatabase();
        }

        void BuildClassDatabase() 
        {
            //int id, string name, double lattitude, double longtitude, int territory, int[] nearbyTowns //multiplier
            nests = new List<Nest>() {
               
                new Nest(1, "Black Rock", 100, 100, 1, new int[]{2},1,false),
                new Nest(2, "Infested Ruins", 100,100, 2, new int[]{1, 5, 10},2,false),               
                new Nest(3, "Swarming Mines", 100,100, 3, new int[]{9, 7, 2},3,false)
            

            };
        }
    

        //get database
        public List<Nest> getNestList() {
            return nests;
        }

     
        public Nest getNest(int position) {
            return nests[position];
        }

        //clear
        public void clearNestList() {
            nests.Clear();
        }

    }
}