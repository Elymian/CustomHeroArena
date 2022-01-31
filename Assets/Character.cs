using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Attribute
{
    public float original, baseline, current, min, max;
    
}
public class Power
{
    public string name;
    public string id;
    public string description;
    public float price;
}
public class Character : MonoBehaviour
{
    Attribute str, agi, tgh, spd, nrg,luck, price, xp, lvl;
    public string owner, o_owner;

    public void Save(FileStream fileStream) 
    {

    }
    public void StrUp()
    {
        if (str.baseline + 1 <= maxStr)
        {
            str++;
            updatePrice();
            Debug.Log("str up!");
        }
        Debug.Log("Tried to go above max strength");
    }
    public void StrDown()
    {
        if (str - 1 >= maxStr)
        {
            str--;
            updatePrice();
            Debug.Log("str down!");
        }
        Debug.Log("Tried to go bellow min strength");
    }
    public void attributeChanger(string input)//Unity button on click can take max 1 variable
    {
        string[] splitted = input.Split(',');
        int length = splitted.Length;
        if(length%2==1)
        {
            Debug.Log("Stat input not in pair, ignoring last.");
            length = length - 1;

        }
        for (int i = 0; i < length-1; i += 2)
        {
            string stat = splitted[i];
            float amount = float.Parse(splitted[i + 1]);
            switch (stat)
            {
                case "str":
                case "strength":
                    if (str + amount <= maxStr && str + amount >= minStr)
                    {
                        str = str + amount;
                    }
                    break;
                case "agi":
                case "agility":
                    if (agi + amount <= maxAgi && agi + amount >= minAgi)
                    {
                        agi = agi + amount;
                    }
                    break;
                case "tgh":
                case "toughness":
                    if (tgh + amount <= maxTgh && tgh + amount >= minTgh)
                    {
                        tgh = tgh + amount;
                    }
                    break;
                case "spd":
                case "speed":
                    if (spd + amount <= maxSpd && spd + amount >= minSpd)
                    {
                        spd = spd + amount;
                    }
                    break;
                case "nrg":
                case "energy":
                    if (nrg + amount <= maxNrg && nrg + amount >= minNrg)
                    {
                        nrg = nrg + amount;
                    }
                    break;
                case "xp":
                case "experience":
                    if (xp + amount <= maxXp && spd + amount >= minXp)
                    {
                        xp = xp + amount;
                    }
                    break;
                case "lvl":
                case "level":
                    if (lvl + amount <= maxLvl && lvl + amount >= minLvl)
                    {
                        lvl = lvl + amount;
                    }
                    break;
                case "luck":
                    if (luck + amount <= maxLuck && luck + amount >= minLuck)
                    {
                        luck = luck + amount;
                    }
                    break;
                case "price":
                    if (price + amount <= maxPrice && price + amount >= minPrice)
                    {
                        price = price + amount;
                    }
                    break;
                case "maxluck":
                case "maxLuck":
                case "max luck":
                    maxLuck = maxLuck + amount;
                    break;
                case "maxstr":
                case "maxStr":
                case "max str":
                    maxStr = maxStr + amount;
                    break;
                case "maxagi":
                case "maxAgi":
                case "max agi":
                    maxAgi = maxAgi + amount;
                    break;
                case "maxtgh":
                case "maxTgh":
                case "max tgh":
                    maxTgh = maxTgh + amount;
                    break;
                case "maxspd":
                case "maxSpd":
                case "max spd":
                    maxSpd += amount;
                    break;
                case "maxnrg":
                case "maxNrg":
                case "max nrg":
                    maxNrg += amount;
                    break;
            }
        }
        updatePrice();//This should be eventually removed from this function.
    }
    public void updatePrice()
    {
        price = 0;
        price += getAttributePrice(str);
        price += getAttributePrice(agi);
        price += getAttributePrice(tgh);
        price += getAttributePrice(spd);
        price += getAttributePrice(nrg);
        price += getAttributePrice(luck);
        foreach (string special in this.specials.Split('#'))
        {
            price += getSpecialPrice(special);
        }    
    }
    public float getSpecialPrice(string power)
    {
        switch(power)
        {
            case "1goliath":
                return 1000;
        }
        return 0;
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
    public void addSpecial(string special)
    {
        this.specials = specials + "#" + special;
    }
    public void removeSpecial(string special)//From now on specials cannot contain #[number]
    {
        this.specials = this.specials.Replace("#"+special, "");
        this. specials =this.specials.Replace("##", "");
    }
}
