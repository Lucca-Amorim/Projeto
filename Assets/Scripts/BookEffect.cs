using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookEffect : MonoBehaviour{

    public string whoAmI; //com isso no editor, o livro vai se identificar
    private int settin; //vai transferir isso para o sistema de casos
    private bool taCerto;
    public PlayerMovement mova;
    public Animator animator;
    private float mudanca = 1;

    public GameObject emptyGameObjectPrefab;

    //public bool First = false;
    public int livros;

    void Start() {
        animator = GetComponent<Animator>();
        //for(int y = 0; y < livros; y++){
        //    Instantiate(emptyGameObjectPrefab, transform.position, Quaternion.identity);    
        //}
        
        
        
    }
    void Awake(){
        Buff();    
        Debuff();
    }

    void FixedUpdate(){
        if(mova.personagemAtual == "Kevin"){
            animator.SetFloat("Blend", mudanca);
            animator.Play("");
        }
    }

    private void Buff(){
        WhoIs();
        switch(settin){
            case 1:
                //Debug.Log("buff caso 1");
                break;
            case 2:
                //Debug.Log("buff caso 2");
                break;
            case 3:
                //Debug.Log("buff caso 3");
                break;
            default:    
                //Debug.Log("buff caso 0");
                break;
        }
    }

    private void Debuff(){
        WhoIs();
        switch(settin){
            case 1:
                //Debug.Log("debuff caso 1");
                break;
            case 2:
                //Debug.Log("debuff caso 2");
                break;
            case 3:
                //Debug.Log("debuff caso 3");
                break;
            default:
                //Debug.Log("debuff caso 0");
                break;
        }
    }
    private void WhoIs(){
        if(whoAmI == "J"){
            settin = 1; 
        }
        if(whoAmI == "K"){
            settin = 2; 
        }
        if(whoAmI == "L"){
            settin = 3; 
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        //animator.SetTrigger("MudancaBAD");
        
    }
}






/*

Thinking Line

preciso identificar de qual criança é o livro, essa identificação sera feita com WhoAmI

para usar switch preciso de uma verificação por numero, metodo WhoIs transforma eles em numeros para o metodo de buff e debuff


metodo buff vai dar buff dependendo do personagem, debuff fara o mesmo


























*/