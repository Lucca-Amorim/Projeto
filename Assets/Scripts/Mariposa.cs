using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Mariposa : enemego{
    int vida;
    
    void start(){
        vida = 3;
    }
    

}
