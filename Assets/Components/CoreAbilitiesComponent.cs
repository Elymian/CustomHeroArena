using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Ability 
{
    public int m_Min;
    public int m_Max;
    public int m_Base;
}

public class CoreAbilitiesComponent : BaseComponent
{
    public Ability m_Str;
    public Ability m_Dex;
    public Ability m_Con;
    public Ability m_Wis;
    public Ability m_Int;
    public Ability m_Cha;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

