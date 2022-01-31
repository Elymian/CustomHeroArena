using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    public float str, agi, tgh, spd, nrg, xp, lvl, luck, o_luck, o_str, o_agi, o_tgh, o_spd, o_nrg, o_xp, o_lvl, o_price, price;
    public float minStr=1, minAgi=1, minTgh=1, minSpd=1, minNrg=1, minXp, minLvl=1, o_minStr, o_minAgi, o_minTgh, o_minSpd, o_minNrg, o_minXp, o_minLvl, o_minPrice, minPrice,minLuck,o_minLuck;
    public float maxLuck = 10,maxStr=10, maxAgi=10, maxTgh=10, maxSpd=10, maxNrg=10, maxXp=10, maxLvl=10, o_maxStr=10, o_maxAgi=10, o_maxTgh=10, o_maxSpd=10, o_maxNrg=10, o_maxXp=1000000000000000f, o_maxLvl=9999, o_maxPrice=10000000000f, maxPrice= 10000000000f;
    public string specials, o_specials;
    public string owner, o_owner;
    public void strUp()
    {
        if (str + 1 <= maxStr)
        {
            str++;
            updatePrice();
            Debug.Log("str up!");
        }
        Debug.Log("Tried to go above max strength");
    }
    public void strDown()
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
