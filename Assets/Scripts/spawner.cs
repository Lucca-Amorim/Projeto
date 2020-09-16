using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour{
    public GameObject inimigo;
    Transform pos;
    float x, y;
    bool feito;

    void Awake(){
        pos = GetComponent<Transform>();
        x = pos.position.x;
        y = pos.position.y;
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        if(!feito){
            //Instantiate(inimigo, new Vector3(x + 1, y + 0.5f, 0), Quaternion.identity);
            feito = true;
        }
    }
    


}
