using UnityEngine;

namespace Sands
{
    public class Item : MonoBehaviour
    {
        private int ID;
        private string itemName;
        private double weight;
        private double price;

        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Item(int ID, string itemName, double weight, double price)
        {
            this.ID = ID;
            this.itemName = itemName;
            this.weight = weight;
            this.price = price;
        }
    }
}
