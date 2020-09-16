using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fazBlocoAndar : MonoBehaviour{

    public float x, y, andar;
    public bool lado = false, andando = false;
    public bool voaCima = false, voaLados = false;
    public CapsuleCollider2D normal; //usa como chao, vai fazer a interação com os triggers
    public PolygonCollider2D pulaPula; //usado para descolar o player e fazer ele bater e sair da perto

    private int leftRight;

    void Start(){
        x = transform.position.x;
        y = transform.position.y;
        qualLado();
    }

    void LateUpdate(){
        movementHandler();
    }

    void OnCollisionEnter2D(Collision2D collision){

        if(collision.gameObject.layer == Layers.triggersLayer){
            trocaLado();
        }
        if(collision.gameObject.layer == Layers.playersLayer){
            andando = true;
            collision.collider.transform.SetParent(transform);
        }

    }

    void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.layer == Layers.playersLayer){
            other.collider.transform.SetParent(null);
        }
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

    private void qualLado(){
        if(Random.value > 50f){
            trocaLado();
        }
    }

        private void trocaLado(){
        lado = !lado;
    }
}