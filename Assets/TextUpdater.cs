using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdater : MonoBehaviour
{
    public void Start()
    {
        manualUpdate();
    }
    public TextMeshProUGUI txtTop;
    public TextMeshProUGUI txtPrice;
    public Character character;
    public void manualUpdate() 
    {
        txtTop.text =
        "LvL: " + character.lvl + " Xp:" + character.xp + "/" + character.maxXp + "\n" +
        "Strength: " + character.str + "\n" +
        "Agility: " + character.agi + "\n" +
        "Toughness: " + character.tgh + "\n" +
        "Speed: " + character.spd + "\n" +
        "Energy: " + character.nrg + "\n" +
        "Luck: " + character.luck + "\n" +
        "-----" +
        "Reflect 50 % of projectiles \n";
        txtPrice.text = "Price " + character.price + "\n";
    }
}
