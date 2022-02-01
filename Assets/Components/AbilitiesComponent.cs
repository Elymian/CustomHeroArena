using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class Ability : MonoBehaviour
{
    public string m_name;
    public string m_Description;
    public float m_Cost;
    public float m_id;
    public float Price()
    {
        float price = 0;
        price += m_Cost;
        return price;
    }
}

public class AbilitiesComponent : BaseComponent
{
    public override void Save(ref Stream stream)
    {
        using (StreamWriter sw = new StreamWriter(stream))
        { }
    }
}

