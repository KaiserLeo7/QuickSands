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
                //string itemName, double weight, double price
                new Tradeable("Cloth", 2, 30.0),
                new Tradeable("Leather", 3, 35.0),
                new Tradeable("Spices", 1, 25.0),
                new Tradeable("Rations", 2, 20.0),
                new Tradeable("Coal", 5, 40.0),
                new Tradeable("Steel", 7, 55.0),
                new Tradeable("Tools", 5, 45.0),
                new Tradeable("Silver", 6, 65.0),
                new Tradeable("Gold", 6, 70.0),
                new Tradeable("Diamonds", 5, 100.0)
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
