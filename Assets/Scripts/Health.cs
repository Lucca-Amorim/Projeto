using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour{
    public static int vida;
    public static int nHearts;
    public Image[] hearts;
    public Sprite fHearts;
    public Sprite eHearts;

    void Start(){
        try{
            nHearts = 3;
            vida = 3;
        }catch(System.Exception){
            
            throw;
        }
    }
    void LateUpdate(){
        heartLoader();
    }

    private void heartLoader(){
        qualPlayer();
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
    void qualPlayer(){
        if(PlayerMovement.personagemStatic == "Julia"){
            nHearts = 5;
            vida = 4;
        }else if(PlayerMovement.personagemStatic == "Kevin"){
            nHearts = 6;
            vida = 5;
        }else if(PlayerMovement.personagemStatic == "Lilly"){
            nHearts = 2;
            vida = 1;
        }
    }
}
