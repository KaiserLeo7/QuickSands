using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands

{
    public class Trader : Vehicle    //3 seater trade vehicle
    {
        public Trader(int id, int maxHP, int currentHP, int speed, int buttspace, int capacity, int price) : base(id, maxHP, currentHP, speed, buttspace, capacity, price) { }

    }

}
