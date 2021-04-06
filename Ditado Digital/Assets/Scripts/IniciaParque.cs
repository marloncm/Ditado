using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciaParque : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    PlayerPrefs.SetInt("acertosparque", 0);
    PlayerPrefs.SetInt("errosparque", 0);  
    PlayerPrefs.Save();
    }


}
