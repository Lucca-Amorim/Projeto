using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
	[Space]
    [Header("Movimentação:")]
	public CharacterController2D controller;
	public float runSpeed = 40f;
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	new Rigidbody2D rigidbody2D;
	BoxCollider2D boxCollider2D;

	[Space]
    [Header("Seleção de Personagem:")]
	public bool Selected = false; 
	public bool descansando = false;
	public string personagem = "Julia";	
	public string personagemAtual;
	public static string personagemStatic;

	[Space]
    [Header("Sistema:")]
	public static bool boradescer = false;


	[Space]
    [Header("Attack System:")]
	public int dano = 2;
	public Transform attackPoint;
    public LayerMask enemyLayers;
    Animator animator;
    public float attackLargura;
	public float attackAltura;
	public float attackDelay;
	public float delayMax = 3; 

    void Start(){
		personagemStatic = "Julia";
		animator = this.gameObject.GetComponent<Animator>();
	}
	void Update(){
		if(Selected & !descansando){
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			if(horizontalMove != 0){
				animator.SetBool("Andar", true);
			}else{
				animator.SetBool("Andar", false);
				//animator.SetBool("Andar", false);
			}
			if(Input.GetKeyDown(KeyCode.R) && attackDelay <= 0){
				Atacar();
			}
			if(Input.GetButtonDown("Jump")){
				jump = true;
				animator.SetBool("Jump", true);
			}
		}
		if(attackDelay >= 0){
			attackDelay -= Time.deltaTime;
		}
		characterHandle();
	}

	void FixedUpdate(){
		if(Selected){
			controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
			jump = false;
		}
	}

	public void isSelected(){
		Selected = false;
		if(personagem == personagemAtual){
			Selected = true;
		}
	}

	public void characterHandle(){
		if((Input.GetKeyDown(KeyCode.J)) || (Input.GetKeyDown(KeyCode.K))  || (Input.GetKeyDown(KeyCode.L))){
			if(Input.GetKeyDown(KeyCode.J)){
				personagemAtual = "Julia";
				personagemStatic = "Julia";
			}else if(Input.GetKeyDown(KeyCode.K)){
				personagemAtual = "Kevin";
				personagemStatic = "Kevin";
			}else if(Input.GetKeyDown(KeyCode.L)){
				personagemAtual = "Lilly";
				personagemStatic = "Lilly";
			}
			isSelected();
		}
	}

	public void trocaCharacter(string nome){
		personagemAtual = nome;
		personagemStatic = nome;
		isSelected();
	}

	private void desceuEscada(){
		descansando = true;
	}

	void Atacar(){
		attackDelay += delayMax;
        Collider2D[] hitEnemies = 
		Physics2D.OverlapBoxAll(attackPoint.position, new Vector2(
			attackLargura, attackAltura), enemyLayers);

        foreach(Collider2D enemy in hitEnemies){
			enemy.GetComponent<enemego>().tiraVd(dano);
			Debug.Log(enemy.name + ": " + enemy.GetComponent<enemego>().vida);
			break;
        }
    }

    void OnDrawGizmosSelected(){
        if(attackPoint == null)
            return;
        Gizmos.DrawWireCube(attackPoint.position, new Vector2(attackLargura, attackAltura));
    }

	public void noChao(){
		animator.SetBool("Jump", false);
	}
	

}