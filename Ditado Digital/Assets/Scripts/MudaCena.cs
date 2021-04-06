using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudaCena : MonoBehaviour
{




    public void trocacena(string scene_name)
    {
     
            SceneManager.LoadScene(scene_name);
        
    }


public void sair()
{
    Application.Quit();
}


}

