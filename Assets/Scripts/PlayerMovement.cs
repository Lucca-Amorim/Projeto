using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

	public CharacterController2D controller;
	private Rigidbody2D rigidbody2D;
	private BoxCollider2D boxCollider2D;

	public float runSpeed = 40f;
	public bool Selected = false; 
	public string personagem = "Julia";
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	
	public string personagemAtual;
	
	void Update(){
		if(Selected){
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			if(Input.GetButtonDown("Jump")){
				jump = true;
			}
		}
		characterHandle();
	}

	void FixedUpdate(){
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}

	public void isSelected(){
		gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
		gameObject.GetComponent<BoxCollider2D>().enabled = false;
		Selected = false;
		if(personagem == personagemAtual){
			gameObject.GetComponent<BoxCollider2D>().enabled = true;
			gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
			Selected = true;
		}
	}

	public void characterHandle(){
		if((Input.GetKeyDown(KeyCode.J)) || (Input.GetKeyDown(KeyCode.K))  || (Input.GetKeyDown(KeyCode.L))){
			if(Input.GetKeyDown(KeyCode.J)){
				personagemAtual = "Julia";
			}else if(Input.GetKeyDown(KeyCode.K)){
				personagemAtual = "Kevin";
			}else if(Input.GetKeyDown(KeyCode.L)){
				personagemAtual = "Lilly";
			}
			isSelected();
		}
	}

	public void trocaCharacter(string nome){
		personagemAtual = nome;
		isSelected();
	}

}