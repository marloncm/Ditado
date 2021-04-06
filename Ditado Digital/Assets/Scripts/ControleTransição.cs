using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement;

public class ControleTransição : MonoBehaviour
{


    private int aux;
    public Text NomeSlot;
    private string cena="";


    [Header("Zoo")]
    public Text zAcertoSlot;
    public Text zErrosSlot;

    [Header("Parque")]
    public Text pAcertoSlot;
    public Text pErrosSlot;
   

    void Start()
    {   aux = PlayerPrefs.GetInt("mundorecente");
        cena = PlayerPrefs.GetString("proxcena");
        NomeSlot.text = PlayerPrefs.GetString("nome");  


        if(aux == 2)
        {
        zAcertoSlot.text = PlayerPrefs.GetInt("acertoszoo").ToString();  
        zErrosSlot.text = PlayerPrefs.GetInt("erroszoo").ToString();  
        } else
        {
        pAcertoSlot.text = PlayerPrefs.GetInt("acertosparque").ToString();  
        pErrosSlot.text = PlayerPrefs.GetInt("errosparque").ToString();             
        }
    }
   
    public void Prox()
    {
       SceneManager.LoadScene(cena);
    }

    public void ClearSave()
    {
       PlayerPrefs.DeleteAll();
       SceneManager.LoadScene("Intro");
    }

    public void ClearZoo()
    {
        PlayerPrefs.SetInt("acertoszoo", 0);
        PlayerPrefs.SetInt("erroszoo", 0);
        PlayerPrefs.Save();
    }

    public void ClearParque()
    {
        PlayerPrefs.SetInt("acertosparque", 0);
        PlayerPrefs.SetInt("errosparque", 0);
        PlayerPrefs.Save();
    }

}