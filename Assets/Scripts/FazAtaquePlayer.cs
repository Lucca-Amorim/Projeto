using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FazAtaquePlayer : MonoBehaviour{
    
    public ParticleSystem ataque;


    void Update(){
        Teste();
    }

    void Teste(){
        if(Input.GetKeyDown(KeyCode.U)){
            ataque.Play();
        }
    }





}
