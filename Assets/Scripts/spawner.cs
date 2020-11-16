using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour{
    public GameObject inimigo;
    Transform pos;
    float x, y;
    bool feito;
    public bool esquerda;
    int lado;
    public bool spawna;

    void Awake(){
        pos = GetComponent<Transform>();
        x = pos.position.x;
        y = pos.position.y;
        lado = 1;
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        if(!feito){
            if(esquerda)
                lado = -1;
            if(!esquerda)
                lado = 1;
            if(spawna)Instantiate(inimigo, new Vector3(x + lado, y + 0.5f, 0), Quaternion.identity);
            feito = true;
        }
    }
    


}
