using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Mariposa : enemego{
    new int vida;
    
    void start(){
        vida = enemego.vida;
    }
    

}
