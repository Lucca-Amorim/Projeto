using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Larva : enemego{
    
    bool deu;
    void start(){
        vida = 6;
    }
    void Update(){
        if(!deu){
            if(vida == 0){
                vida = 6;
                deu = true;
            }
        }
    }

    
}