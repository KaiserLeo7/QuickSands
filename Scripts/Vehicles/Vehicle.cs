using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class Vehicle
    {
        private int maxHP;
        private int currentHP;
        private int speed;
        private int partySize;
        private int capacity;

        public Vehicle(int maxHP, int currentHP, int speed, int partySize, int capacity)
        {
            this.maxHP = maxHP;
            this.currentHP = currentHP;
            this.speed = speed;
            this.speed = speed;
            this.partySize = partySize;
            this.capacity = capacity;
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
    }
}