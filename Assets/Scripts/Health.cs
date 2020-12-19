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
    public Image Hud;
    public Sprite[] players;

    #region Char Healths
    [Header("HP GameObject")]
	[Space]
        public GameObject JHealth;
        public GameObject KHealth;
        public GameObject LHealth;

    #endregion
    
    #region Julia Region
    [Header("Julia")]
    [Space]
        public Image[] JSlots;
        public Sprite[] JLifes;
        int JnHearts;
        int Jvida;


    #endregion
    
    #region Kevin Region
    [Header("Kevin")]
    [Space]
        public Image[] KSlots;
        public Sprite[] KLifes;
        int KnHearts;
        int Kvida;

    #endregion

    #region Lilly Region
    [Header("Lilly")]
    [Space]
        public Image[] LSlots;
        public Sprite[] LLifes;
        int LnHearts;
        int Lvida;

    #endregion


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
        if(Input.GetKeyDown(KeyCode.G))     grava();
        if(nHearts > 4)     nHearts = 4;
		if(Input.GetButtonDown("Fire1")){
            Debug.Log(vida);
            Jvida -= 1;
            Debug.Log("tirou vida");
        }
    }
    void LateUpdate(){
        heartLoader();
    }

    private void heartLoader(){
        qualPlayer();
        for (int i = 0; i < JSlots.Length; i++){
            if(vida > nHearts){
                vida = nHearts;
            }

            /*
            if(i < vida){
                JSlots[i].sprite = JLifes[4];
            }else{
                JSlots[i].sprite = JLifes[0];
            }
            */
            if(i > 0){
                JSlots[i].sprite = JLifes[0];
            }else if(i > 1){
                JSlots[i].sprite = JLifes[1];
            }else if(i > 2){
                JSlots[i].sprite = JLifes[2];
            }
        }
    }

    void counter(int atual){
        if(atual > 1){

        }
    }

    void qualPlayer(){
        if(PlayerMovement.personagemStatic == "Julia"){
            nHearts = JnHearts;
            vida = Jvida;

            Hud.sprite = players[0];
            JHealth.gameObject.SetActive(true);

            KHealth.gameObject.SetActive(false);
            LHealth.gameObject.SetActive(false);

        }else if(PlayerMovement.personagemStatic == "Kevin"){
            nHearts = KnHearts;
            vida = Kvida;

            Hud.sprite = players[1];
            KHealth.gameObject.SetActive(true);

            JHealth.gameObject.SetActive(false);
            LHealth.gameObject.SetActive(false);

        }else if(PlayerMovement.personagemStatic == "Lilly"){
            nHearts = LnHearts;
            vida = Lvida;
            
            Hud.sprite = players[2];
            LHealth.gameObject.SetActive(true);

            JHealth.gameObject.SetActive(false);
            KHealth.gameObject.SetActive(false);
        }
    }


    #region Save/Load Vidas
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
    #endregion
    
}
