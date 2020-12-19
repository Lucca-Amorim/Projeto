using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caiu : MonoBehaviour{

    float descida;
    bool caindo;
    float velocidade = 0.07f;
    public bool pronto;

    public void Start(){
        descida = transform.position.y * 1.64f;
    }

    public void Update(){
        if(caindo){
            if(descida < transform.position.y){
                transform.position = new Vector3(transform.position.x, 
                                                transform.position.y - velocidade, 
                                                transform.position.z);
            }else{
                caindo = false;
                pronto = true;
            }
        }
    }

    public void OnCollisionStay2D(Collision2D collision){
        if(collision.gameObject.layer == Layers.playersLayer){
            if(Input.GetKeyDown(KeyCode.E)){
                caindo = true;
            }
        }
    }
}