using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour{
    public int vida;
    public int nHearts;    
    public Image[] hearts;
    public Sprite fHearts;
    public Sprite eHearts;
    //Julia
    int JnHearts;
    int Jvida;
    //Kevin
    int KnHearts;
    int Kvida;
    //Lilly
    int LnHearts;
    int Lvida;

    void Start(){
        try{
            StreamReader reader = new StreamReader("vida.txt");

            string temp = reader.ReadLine();
            JnHearts = Int32.Parse(temp);
            temp = reader.ReadLine();
            Jvida = Int32.Parse(temp);

            temp = reader.ReadLine();
            KnHearts = Int32.Parse(temp);
            temp = reader.ReadLine();
            Kvida = Int32.Parse(temp);

            temp = reader.ReadLine();
            LnHearts = Int32.Parse(temp);
            temp = reader.ReadLine();
            Lvida = Int32.Parse(temp);

            reader.Close();
        }catch(System.Exception){
            Debug.Log("erro ao ler as vidas, ver compatibilidade com o documento de int ao string");
            throw;
        }
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.G)){
            grava();
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
            nHearts = JnHearts;
            vida = Jvida;
        }else if(PlayerMovement.personagemStatic == "Kevin"){
            nHearts = KnHearts;
            vida = Kvida;
        }else if(PlayerMovement.personagemStatic == "Lilly"){
            nHearts = LnHearts;
            vida = Lvida;
        }
    }

    public void mudaVida(int slots, int vidinha){
        PlayerMovement temp = new PlayerMovement();
        switch(PlayerMovement.personagemStatic){
            case "Julia":
                JnHearts += slots;
                Jvida += vidinha;
                break;
            case "Kevin":
                KnHearts += slots;
                Kvida += vidinha;
                break;
            case "Lilly":
                LnHearts += slots;
                Lvida += vidinha;
                break;
            default:
                Debug.Log("nada");
                break;
        }
        Debug.Log(JnHearts);
    }
    public void grava(){
        StreamWriter writer = new StreamWriter("vida.txt");
        writer.WriteLine(JnHearts);
        writer.WriteLine(Jvida);

        writer.WriteLine(KnHearts);
        writer.WriteLine(Kvida);

        writer.WriteLine(LnHearts);
        writer.WriteLine(Lvida);
        writer.Close();
    }
}
