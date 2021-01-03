using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Sands
{
    public class BattleHUD : MonoBehaviour
    {

        public Text nameText;
        public Text levelText;

        public Slider hpSlider;
        public Gradient gradient;
        public Image fill;


        public void SetHUD(Hero unit)
        {


            hpSlider.maxValue = unit.MaxHP;
            hpSlider.value = unit.CurrentHP;

            fill.color = gradient.Evaluate(1f);
        }

        public void SetHP(int hp)
        {

            hpSlider.value = hp;

            fill.color = gradient.Evaluate(hpSlider.normalizedValue);
        }

    }

}
