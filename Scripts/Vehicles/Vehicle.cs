using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class Vehicle
    {
        private int id;
        private int maxHP;
        private int currentHP;
        private int speed;
        private int partySize;
        private int capacity;
        private int price;

        public Vehicle(int id, int maxHP, int currentHP, int speed, int partySize, int capacity, int price)
        {
            this.id = id;
            this.maxHP = maxHP;
            this.currentHP = currentHP;
            this.speed = speed;
            this.speed = speed;
            this.partySize = partySize;
            this.capacity = capacity;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int MaxHP
        {
            get
            {
                return maxHP;
            }
            set
            {
                maxHP = value;
            }
        }

        public int CurrentHP
        {
            get
            {
                return currentHP;
            }
            set
            {
                currentHP = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public int PartySize
        {
            get
            {
                return partySize;
            }

            set
            {
                partySize = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }

        public int Price
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
    }
}