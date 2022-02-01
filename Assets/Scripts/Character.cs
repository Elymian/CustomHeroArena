using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//[System.Serializable]
public class Character : MonoBehaviour
{
    public AttributesComponent attributes;
    public AbilitiesComponent abilities;
    public string owner, o_owner;
    public void Save(FileStream fileStream) 
    {

    }
}
