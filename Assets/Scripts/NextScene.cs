using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour{
    public int cena;

    public void OnChange(){
        SceneManager.LoadScene(cena);
    }
}
