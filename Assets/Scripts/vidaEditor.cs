using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaEditor : MonoBehaviour{
    //sim esse é um fucking codigo só pra mudar a vida dos personagens pq a merda da vida ta statica

    public int slotTotal, vidaTotal;

    void LateUpdate(){
        trocaEssaMerda();
    }

    private void trocaEssaMerda(){
        if(Input.GetKeyDown(KeyCode.Alpha5)){
            Health.nHearts = slotTotal;
            Health.vida = vidaTotal;
        }
    }

    
}
