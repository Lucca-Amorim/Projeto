using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour{
    public int cena;

    // Start is called before the first frame update
    void Start(){
        if(cena == null){
            cena = 0;
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
    public void OnChange(){
        SceneManager.LoadScene(cena);
    }
}
