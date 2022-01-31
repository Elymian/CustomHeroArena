using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class Attribute 
{
    public float m_Base;
    public float m_Original;
    public float m_Baseline;
    public float m_Current;
    public float m_Min;
    public float m_Max;
}

public class Power
{
    public string m_Name;
    public string m_Id;
    public string m_Description;
    public float m_Price;
}

public class CoreAbilitiesComponent : BaseComponent
{
    public Attribute m_Str;
    public Attribute m_Agi;
    public Attribute m_Con;
    public Attribute m_Nrg;
    public Attribute m_Spd;
    public Attribute m_Luck;
    public Attribute m_Cha;
    public Attribute m_Price;
    public Attribute m_Xp;
    public Attribute m_Lvl;

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
}

