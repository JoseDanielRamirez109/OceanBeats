using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class drumButton : MonoBehaviour
{
    //public string counter = Input.;


    void Update()
    {
        //input
        //click = Input.GetMouseButton();
    }
   public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
