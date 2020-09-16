using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
	/* Objetos*/
	public CharacterController2D controller;
	private new Rigidbody2D rigidbody2D;
	private BoxCollider2D boxCollider2D;
	
	/* Floats */
	public float runSpeed = 40f;
	float horizontalMove = 0f;

	/* booleanas */ 
	public bool Selected = false; 
	bool jump = false;
	bool crouch = false;
	public bool descansando = false;
	public static bool boradescer = false;

	/* strings */
	public string personagem = "Julia";	
	public string personagemAtual;
	public static string personagemStatic;
	
	void Start(){
		personagemStatic = "Julia";
	}
	void Update(){
		if(Selected & !descansando){
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			if(Input.GetButtonDown("Jump")){
				jump = true;
			}
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


	

}