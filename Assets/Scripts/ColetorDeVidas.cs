using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetorDeVidas : MonoBehaviour{
    public float y,andar;
    public bool lado = false, andando = false;
    public int slotHearts, vidinha;
    void Start(){
        y = transform.position.y;
    }
    void OnCollisionEnter2D(Collision2D collision){
        Health.nHearts += slotHearts;
        Health.vida += vidinha;
        Destroy(gameObject);

    }
    
}
