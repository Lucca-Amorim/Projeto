using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour{
    public GameObject JuliaObj;
    public GameObject KevinObj;
    public GameObject LillyObj;
    
    PlayerMovement Lilly;
    PlayerMovement Kevin;
    PlayerMovement Julia;



    void Start(){
        transform.position = JuliaObj.transform.position;
        Julia = JuliaObj.GetComponent<PlayerMovement>();
        Kevin = KevinObj.GetComponent<PlayerMovement>();
        Lilly = LillyObj.GetComponent<PlayerMovement>();
    }
    
    void LateUpdate(){
        if(Julia.Selected == true){
            transform.position = JuliaObj.transform.position;
        }else if(Kevin.Selected == true){
            transform.position = KevinObj.transform.position;
        }else if(Lilly.Selected == true){
            transform.position = LillyObj.transform.position;
        }
        
    }
}
