using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciaZoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    PlayerPrefs.SetInt("acertoszoo", 0);
    PlayerPrefs.SetInt("erroszoo", 0);  
    PlayerPrefs.Save();
    }

}
