using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement;

public class SavePrefs : MonoBehaviour
{
    private string cena = "";
    public InputField textBox;
   // public Text NameBox;

    public void SaveNome ()
    {
        PlayerPrefs.SetString("nome", textBox.text);
        PlayerPrefs.Save();
    }


public void LoadParque()
{
    if (PlayerPrefs.HasKey("cenaparque"))
    {
        cena = PlayerPrefs.GetString("cenaparque");
        SceneManager.LoadScene(cena);
    } else
      {
       SceneManager.LoadScene("1-Pipoca");   
      }
}

public void LoadZoo()
{
    if (PlayerPrefs.HasKey("cenazoo"))
    {
        cena = PlayerPrefs.GetString("cenazoo");
        SceneManager.LoadScene(cena);
    } else
      {
       SceneManager.LoadScene("1-urso");   
      }
}





/*
    void Start()
    {
       NameBox.text = PlayerPrefs.GetString("nome");  
    }
   

    public void ResetNome()
    {
        PlayerPrefs.DeleteKey("nome");
    }
*/

}
