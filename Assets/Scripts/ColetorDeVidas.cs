using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetorDeVidas : MonoBehaviour{

    public int slotHearts, vidinha;
    public GameObject asistant;
    Health vida;


    void Start() {
        vida = asistant.GetComponent<Assisti>().vida.GetComponent<Health>();
    }

    void OnCollisionEnter2D(Collision2D collision){
        vida.mudaVida(slotHearts, vidinha);
        Destroy(gameObject);
    }

    
}
