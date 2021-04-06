using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalvaParque : MonoBehaviour
{
public string recente = "";

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("cenaparque", recente);
        PlayerPrefs.SetInt("mundorecente", 1);  
        PlayerPrefs.Save();
    }


}
