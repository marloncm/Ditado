using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    
public class saveloadcena : MonoBehaviour
{
    

    public GameObject menuPanel;
    public string recenteparque="";
    public string recentezoo="";
    public int fase=0;
    private int recente;
    

    void start (){

    menuPanel.SetActive(false);

    if(fase == 1)
    //public void salvaparque()
    {
        PlayerPrefs.SetString("cenaparque", recenteparque);
        PlayerPrefs.SetInt("mundorecente", 1);
    }//FIM DO SALVAPARQUE

    
    if(fase==2)//public void salvazoo()
    {
        PlayerPrefs.SetString("cenazoo", recentezoo);
        PlayerPrefs.SetInt("mundorecente", 2);
    }//FIM DO SALVAZOO
    }


    public void loadfase()
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
        else abremenu();
    }//FIM DO LOADFASE

public void abremenu(){
menuPanel.SetActive(true);
}

 
public void fechamenu(){
menuPanel.SetActive(false);
}


//FIM DA CLASSE MAIN
}