using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetorDeVidas : MonoBehaviour{
    public float y,andar;
    public bool lado = false, andando = false;
    void Start(){
        y = transform.position.y;

    }
    void OnCollisionEnter2D(Collision2D collision){
        Health.nHearts += 1;
        Destroy(gameObject);

    }
    
}
