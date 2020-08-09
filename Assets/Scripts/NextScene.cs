using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour{
    public int cena;
    public bool debuging = false;
    public int debugCena;

    public void OnChange(){
        SceneManager.LoadScene(cena);
    }

    void Update(){
        if(debuging == true){
            if(Input.GetKeyDown(KeyCode.P)){
            SceneManager.LoadScene(cena);
            }
        }
    }
}
