using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fazBlocoAndar : MonoBehaviour{

    public float x,y,andar;
    public bool lado = false, andando = false;
    public bool voaCima = false, voaLados = false;
    public GameObject Game;
    
    void Start(){
        x = transform.position.x;
        y = transform.position.y;
    }
    void LateUpdate(){
        movementHandler();
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.layer == 14){
            trocaLado();
        }else if(collision.gameObject.layer == 9){
            andando = true;
            collision.collider.transform.SetParent(transform);
        }
        
        
    }

    void OnCollisionExit2D(Collision2D other) {
        other.collider.transform.SetParent(Game.transform);
    }

    private void trocaLado(){
        lado = !lado;
    }
    private void movementHandler(){
        transform.position = new Vector3(x, y, transform.position.z);
        if(lado){
            if(voaLados){
                x +=andar;
            }
            if(voaCima){
                y +=andar;
            }
        }else if(!lado){
            if(voaLados){
                x -=andar;
            }
            if(voaCima){
                y -=andar;
            }
        }
    }
}