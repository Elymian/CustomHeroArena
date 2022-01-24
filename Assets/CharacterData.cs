using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class CharacterData
{
    public float str, agi, tgh, spd, nrg, xp, lvl, o_str, o_agi, o_tgh, o_spd, o_nrg, o_xp, o_lvl, price, o_price;
    public string specials, o_specials;
    public string owner, o_owner;

    public CharacterData(Character character)
    {
        str = character.str;
        agi = character.agi;
        tgh = character.tgh;
        spd = character.spd;
        nrg = character.nrg;
        xp = character.xp;
        lvl = character.lvl;
        specials = character.specials;
        owner = character.owner;
        price = character.price;

        o_str = character.o_str;
        o_agi = character.o_agi;
        o_tgh = character.o_tgh;
        o_spd = character.o_spd;
        o_nrg = character.o_nrg;
        o_xp = character.o_xp;
        o_lvl = character.o_lvl;
        o_specials = character.o_specials;
        o_owner = character.o_owner;
        o_price = character.o_price;
    }
}
 
