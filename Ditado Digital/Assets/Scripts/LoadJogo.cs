using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadJogo : MonoBehaviour
{
    public GameObject menuPanel;
    private string recenteparque="";
    private string recentezoo="";
    private int recente;

    // Start is called before the first frame update
    void Start()
    {  
        menuPanel.SetActive(false);
    }

 public void Load()
{
 if (PlayerPrefs.HasKey("mundorecente"))
        {
            recente = PlayerPrefs.GetInt("mundorecente");

            if(recente == 1)
            {
                recenteparque = PlayerPrefs.GetString("cenaparque");
                SceneManager.LoadScene(recenteparque);
            }//Fim If 1

            if(recente == 2)
            {
                recentezoo = PlayerPrefs.GetString("cenazoo");
                SceneManager.LoadScene(recentezoo);
            }//Fim If 2

        }//FIM IF HASKEY
        else menuPanel.SetActive(true);
}
}

