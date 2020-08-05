using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tranformerP : MonoBehaviour{
    public GameObject objeto;
    public Vector3 scaleChange;
    
    void Start(){
        /*scaleChange = new Vector3(Screen.width / 700, Screen.height / 700, 0);
        if(scaleChange == new Vector3(0,0,0)){
            scaleChange = new Vector3(0.2f,0.2f,0.2f);
        }
        transform.localScale = objeto.transform.localScale;*/
    }
        //transform.Scale = (10,10,10);
    

    // Update is called once per frame
    void FixedUpdate(){
        transform.localScale = objeto.transform.localScale;
    }
}
