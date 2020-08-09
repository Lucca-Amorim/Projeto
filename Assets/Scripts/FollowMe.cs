using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour{
    public PlayerMovement Julia;
    public GameObject JuliaObj;
    public PlayerMovement Kevin;
    public GameObject KevinObj;
    public PlayerMovement Lilly;
    public GameObject LillyObj;

    void Start(){
        transform.position = JuliaObj.transform.position;
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
