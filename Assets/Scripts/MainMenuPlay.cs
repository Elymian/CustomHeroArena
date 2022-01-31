using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPlay : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("TeamSelector");
        Debug.Log("TeamSelector scene loaded!");
    }
    public void TeamEditor()
    {
        SceneManager.LoadScene("CharacterEditor");
        Debug.Log("CharacterEditor scene loaded!");
    }
}