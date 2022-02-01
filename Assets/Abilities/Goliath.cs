using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goliath : Ability
{
    Goliath()
    {
        m_name = "Goliath";
        m_Description =
            "So strong, so big! A little bit clumsy.\n\n" +
            "+1 str, +1 max str \n" +
            "+1 tgh, +1 max tgh \n" +
            "-1 agi, -1 max agi \n" +
            "-1 spd, -1 max spd \n";
        m_Cost = 1000;
        m_id = 1;

    } 
}