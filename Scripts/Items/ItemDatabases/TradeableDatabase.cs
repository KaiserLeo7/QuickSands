using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands {
    public class TradeableDatabase {

        private List<Tradeable> tradeables = new List<Tradeable>();

        //get database
        public List<Tradeable> getTradeableList() {
            return tradeables;
        }

        //get Hero at position
        public Tradeable getTradeable(int position) {
            return tradeables[position];
        }

        //delete
        public List<Tradeable> deleteTradeable(Tradeable tradeable) {
            return tradeables = tradeables.Except(tradeables.Where(t => t.ItemName == tradeable.ItemName)).ToList();
        }

        //clear
        public void clearTradeableList() {
            tradeables.Clear();
        }

    }
}
