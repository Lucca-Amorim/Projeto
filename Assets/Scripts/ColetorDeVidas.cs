using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetorDeVidas : MonoBehaviour{
    public float y,x,vel;
    public bool lado = false, vertical = false, horizontal = false;
    public int slotHearts, vidinha;
    void Start(){
        y = transform.position.y;
        x = transform.position.x;
    }

    void OnCollisionEnter2D(Collision2D collision){
        Health vida = new Health();
        vida.mudaVida(slotHearts, vidinha);
        Destroy(gameObject);
    }

    void FixedUpdate(){
        movementHandler();
    }

    private void movementHandler(){
        transform.position = new Vector3(x, y, transform.position.z);
        if(lado){
            if(horizontal){
                x +=vel;
            }
            if(vertical){
                y +=vel;
            }
        }else if(!lado){
            if(horizontal){
                x -=vel;
            }
            if(vertical){
                y -=vel;
            }
        }
    }
    
}
