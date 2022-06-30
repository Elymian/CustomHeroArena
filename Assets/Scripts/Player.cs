using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public List<Team> teamList = new List<Team>();
    private string id;
    Player() 
    {
        id = Time.realtimeSinceStartup.ToString() + System.DateTime.Now.ToString("yy/MM/dd HH:mm:ss:fff");
    }
    public void NewTeam(string teamName)
    {
        teamList.Add(new Team());
    }
}
