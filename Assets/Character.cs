using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float str, agi, tgh, spd, nrg, xp, lvl, luck, o_luck, o_str, o_agi, o_tgh, o_spd, o_nrg, o_xp, o_lvl, o_price, price;
    public float minStr, minAgi, minTgh, minSpd, minNrg, minXp, minLvl, o_minStr, o_minAgi, o_minTgh, o_minSpd, o_minNrg, o_minXp, o_minLvl, o_minPrice, minPrice,minLuck,o_minLuck;
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
        string stat = splitted[0];
        float amount = float.Parse(splitted[1]);
        switch (stat)
        {
            case "str":
            case "strength":
                if (str + amount <= maxStr && str + amount >=minStr)
                {
                    str= str+amount;                   
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
          
        }
        updatePrice();
        Debug.Log("str up!");
    }
    public void updatePrice()
    {
        price = 0;
        for (int i = 0; i <= str; i++)
            price += 100 * i;
        for (int i = 0; i <= agi; i++)
            price += 100 * i;
        for (int i = 0; i <= tgh; i++)
            price +=  100 * i;
        for (int i = 0; i <= spd; i++)
            price += 100 * i;
        for (int i = 0; i <= nrg; i++)
            price +=  100 * i;
        for (int i = 0; i <= luck; i++)
            price += 100 * i;
    }
}
