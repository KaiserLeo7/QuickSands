using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleHUD : MonoBehaviour {

    public Text nameText;
    public Text levelText;

    public Slider hpSlider;
    public Gradient gradient;
    public Image fill;
   

    public void SetHUD(Hero unit) {

        nameText.text = unit.unitName;
        levelText.text = "Lvl " + unit.unitLevel;

        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.currentHP;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHP(int hp) {

        hpSlider.value = hp;

        fill.color = gradient.Evaluate(hpSlider.normalizedValue);
    }

}
