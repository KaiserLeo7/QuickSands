using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class TradeableDatabase
    {
        private static List<Tradeable> tradeables = new List<Tradeable>();

        //get database
        public List<Tradeable> getTradeableList()
        {
            return tradeables;
        }

        void BuildClassDatabase()
        {
            tradeables = new List<Tradeable>() {
                //string itemName, int weight, double price
                new Tradeable(1, "Cloth", 2, 30.0),
                new Tradeable(2, "Leather", 3, 35.0),
                new Tradeable(3, "Spices", 1, 25.0),
                new Tradeable(4, "Rations", 2, 20.0),
                new Tradeable(5, "Coal", 5, 40.0),
                new Tradeable(6, "Steel", 7, 55.0),
                new Tradeable(7, "Tools", 5, 45.0),
                new Tradeable(8, "Silver", 6, 65.0),
                new Tradeable(9, "Gold", 6, 70.0),
                new Tradeable(10, "Diamonds", 5, 100.0)
            };
        }

        //get Hero at position
        public Tradeable getTradeable(int position)
        {
            return tradeables[position];
        }

        //clear
        public void clearTradeableList()
        {
            tradeables.Clear();
        }
    }
}
