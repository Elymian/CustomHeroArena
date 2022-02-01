
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class CharacterSaveSystem
{ 
    
    public static void SaveCharacter(Character character)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        
        string path = Application.persistentDataPath + "/"+ character.name +".char";
       /* if(File.Exists(path)) 
        {
            int counter = 0;
            while (File.Exists(path))
            {
                path = Application.persistentDataPath + "/" + character.name + counter + ".char";
                counter++;
            }
        }*/
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, character);
        stream.Close();
    }
    public static Character LoadCharacter(string characterName)
    {
        string path = Application.persistentDataPath + "/" + characterName + ".char";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Character data = formatter.Deserialize(stream) as Character;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("File not found at " + path);
            return null;
        }

    }
}
