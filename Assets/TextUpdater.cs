using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdater : MonoBehaviour
{
    public void Start()
    {
        StatReminderUpdate();
    }
    public TextMeshProUGUI txtStats;
    public TextMeshProUGUI txtPrice;
    public TextMeshProUGUI txtFlavor;
    public Character character;
    public void StatReminderUpdate() 
    {
        txtStats.text =
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
    public void goliathFlavor()
    {
        txtFlavor.text = "So strong, so big! A little bit clumsy.\n\n" +
            "+1 str, +1 max str \n" +
            "+1 tgh, +1 max tgh \n" +
            "-1 agi, -1 max agi \n" +
            "-1 spd, -1 max spd.";
    }
}
