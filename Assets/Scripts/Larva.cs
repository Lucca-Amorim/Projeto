using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Larva : enemego{
    private new int vida;
    void start(){
        vida = enemego.vida;
    }
}