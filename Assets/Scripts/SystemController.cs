using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SystemController : MonoBehaviour{   
    public int cena;

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
        else if(Input.GetKey(KeyCode.B)){
            SceneManager.LoadScene(cena);
        }
    }
}
