using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdater : MonoBehaviour
{

    public TextMeshProUGUI txtStats;
    public TextMeshProUGUI txtPrice;
    public TextMeshProUGUI txtFlavor;
    public Character character;
    
    public void StatReminderUpdate() 
    {

        txtStats.text = 
        "LvL: " + character.attributes.m_Lvl.m_Baseline + " Xp:" + character.attributes.m_Xp.m_Baseline  + "/" + character.attributes.m_Xp.m_Max + "\n" +
        "Strength: " + character.attributes.m_Lvl.m_Current + "\n" +
        "Agility: " + character.attributes.m_Agi.m_Baseline + "\n" +
        "Constitution: " + character.attributes.m_Agi.m_Baseline + "\n" +
        "Speed: " + character.attributes.m_Spd.m_Baseline + "\n" +
        "Energy: " + character.attributes.m_Nrg.m_Baseline + "\n" +
        "Luck: " + character.attributes.m_Luck.m_Baseline + "\n" +
        "-----" + "\n";

        txtPrice.text = "Price " + character.attributes.m_Price.m_Baseline + "\n";
    }
    public void Flavor(Ability ability)
    {
        txtFlavor.text = ability.m_Description;
    }
    public void Start()
    {
        StatReminderUpdate();
    }
}
