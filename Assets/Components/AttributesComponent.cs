using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class Attribute
{
    public float m_Original;
    public float m_Baseline;
    public float m_Current;
    public float m_Min;
    public float m_Max;
}

public class AttributesComponent : BaseComponent
{
    public Attribute m_Str { get; set; }
    public Attribute m_Agi { get; set; }
    public Attribute m_Con { get; set; }
    public Attribute m_Nrg { get; set; }
    public Attribute m_Spd { get; set; }
    public Attribute m_Luck { get; set; }
    public Attribute m_Cha { get; set; }
    public Attribute m_Price { get; set; }
    public Attribute m_Xp { get; set; }
    public Attribute m_Lvl { get; set; }
    public override void Save(ref Stream stream)
    {
        using (StreamWriter sw = new StreamWriter(stream))
        {
            sw.Write(m_Str);
            sw.Write(m_Agi);
            sw.Write(m_Con);
            sw.Write(m_Nrg);
            sw.Write(m_Spd);
            sw.Write(m_Luck);
            sw.Write(m_Cha);
            sw.Write(m_Price);
            sw.Write(m_Xp);
            sw.Write(m_Lvl);
            sw.Write(m_Cha);
        }
    }
    public float getAttributePrice(float attribute)
    {
        if (attribute == 0)
            return -1000;
        float price = 0;
        for (int i = 0; i <= attribute; i++)
            price += 100 * i;
        return price;
    }
    public float Price()
    {
        float price = 0;
        price += getAttributePrice(m_Str.m_Baseline);
        price += getAttributePrice(m_Agi.m_Baseline);
        price += getAttributePrice(m_Con.m_Baseline);
        price += getAttributePrice(m_Spd.m_Baseline);
        price += getAttributePrice(m_Nrg.m_Baseline);
        price += getAttributePrice(m_Luck.m_Baseline);
        return price;
    }
    public void attributeChanger(string input)//Unity button on click can take max 1 variable
    {
        string[] splitted = input.Split(',');
        int length = splitted.Length;
        if (length % 2 == 1)
        {
            Debug.Log("Stat input not in pair, ignoring last.");
            length = length - 1;

        }
        for (int i = 0; i < length - 1; i += 2)
        {
            string stat = splitted[i];
            float amount = float.Parse(splitted[i + 1]);
            switch (stat)
            {
                case "str":
                case "strength":
                    if (m_Str.m_Baseline + amount <= m_Str.m_Max && m_Str.m_Baseline + amount >= m_Str.m_Min)
                    {
                        m_Str.m_Baseline += amount;
                    }
                    break;
                case "agi":
                case "agility":
                    if (m_Agi.m_Baseline + amount <= m_Agi.m_Max && m_Agi.m_Baseline + amount >= m_Agi.m_Min)
                    {
                        m_Agi.m_Baseline += amount;
                    }
                    break;
                case "tgh":
                case "toughness":
                case "con":
                case "constitution":
                    if (m_Con.m_Baseline + amount <= m_Con.m_Max && m_Con.m_Baseline + amount >= m_Con.m_Min)
                    {
                        m_Con.m_Baseline += amount;
                    }
                    break;
                case "spd":
                case "speed":
                    if (m_Spd.m_Baseline + amount <= m_Spd.m_Max && m_Spd.m_Baseline + amount >= m_Spd.m_Min)
                    {
                        m_Spd.m_Baseline += amount;
                    }
                    break;
                case "nrg":
                case "energy":
                    if (m_Nrg.m_Baseline + amount <= m_Nrg.m_Max && m_Nrg.m_Baseline + amount >= m_Nrg.m_Min)
                    {
                        m_Nrg.m_Baseline += amount;
                    }
                    break;
                case "xp":
                case "experience":
                    if (m_Xp.m_Baseline + amount <= m_Xp.m_Max && m_Xp.m_Baseline + amount >= m_Xp.m_Min)
                    {
                        m_Xp.m_Baseline += amount;
                    }
                    break;
                case "lvl":
                case "level":
                    if (m_Lvl.m_Baseline + amount <= m_Lvl.m_Max && m_Lvl.m_Baseline + amount >= m_Lvl.m_Min)
                    {
                        m_Lvl.m_Baseline += amount;
                    }
                    break;
                case "luck":
                    if (m_Luck.m_Baseline + amount <= m_Luck.m_Max && m_Luck.m_Baseline + amount >= m_Luck.m_Min)
                    {
                        m_Luck.m_Baseline += amount;
                    }
                    break;
                case "maxluck":
                case "maxLuck":
                case "max luck":
                    m_Luck.m_Max += amount;
                    break;
                case "maxstr":
                case "maxStr":
                case "max str":
                    m_Str.m_Max += amount;
                    break;
                case "maxagi":
                case "maxAgi":
                case "max agi":
                    m_Agi.m_Max += amount;
                    break;
                case "maxtgh":
                case "maxTgh":
                case "max tgh":
                case "maxCon":
                case "maxcon":
                case "max con":
                    m_Con.m_Max += amount;
                    break;
                case "maxspd":
                case "maxSpd":
                case "max spd":
                    m_Spd.m_Max += amount;
                    break;
                case "maxnrg":
                case "maxNrg":
                case "max nrg":
                    m_Nrg.m_Max += amount;
                    break;
            }
        }
       m_Price.m_Baseline = Price();
    }
}

