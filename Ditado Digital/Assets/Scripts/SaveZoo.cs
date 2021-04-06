using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveZoo : MonoBehaviour
{
public string recente = "";

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("cenazoo", recente);
        PlayerPrefs.SetInt("mundorecente", 2);  
        PlayerPrefs.Save();
    }
}
