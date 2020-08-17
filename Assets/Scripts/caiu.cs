using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class caiu : MonoBehaviour{
    public float y, total;
    public float vel = 0.1f;
    public RectTransform pos;
    void Start(){
        pos = GetComponent<RectTransform>();
        y = pos.localPosition.y;
        total = y / 4.140288f;
        vel = 0.03f;
    }
    
    void LateUpdate(){
        if(PlayerMovement.boradescer)
            cuidaDescer();
    }

    public void cuidaDescer(){
        pos.localPosition = new Vector2(pos.localPosition.x, y);
        if(y > total){
            y -= vel;
        }else{
            PlayerMovement.boradescer = false;
        }        
    }



















}
