using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSave : MonoBehaviour
{
    private string _name;

    private DreamItem _dream;
    private bool _dreamCameTrue;


    private void Save()
    {
        PlayerPrefs.SetString("SaveGame", JsonUtility.ToJson(this));
    }

    private void Load()
    {
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("SaveGame"), this);
    }

    public void SendName(string newName)
    {
        _name = newName;
    }

    public void SendDream(DreamItem newDream)
    {
        _dream = newDream;
    }

    private void Update()
    {
        Debug.Log(_dream);
    }
}
