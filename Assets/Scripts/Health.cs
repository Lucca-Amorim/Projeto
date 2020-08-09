using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour{
    public int vida;
    public static int nHearts;

    public Image[] hearts;
    public Sprite fHearts;
    public Sprite eHearts;

    void Start(){
        try{
            nHearts = 3;
        }catch (System.Exception){
            
            throw;
        }
    }
    void LateUpdate(){
        for (int i = 0; i < hearts.Length; i++){
            if(vida > nHearts){
                vida = nHearts;
            }

            if(i < vida){
                hearts[i].sprite = fHearts;
            }else{
                hearts[i].sprite = eHearts;
            }

            if(i < nHearts){
                hearts[i].gameObject.SetActive(true);
            }else{
                hearts[i].gameObject.SetActive(false);
            }
        }
    }
}
