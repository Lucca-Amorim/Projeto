using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	private Rigidbody2D rigidbody2D;
	private BoxCollider2D boxCollider2D;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	public bool Selected = false; 
	public int personagem;
	
	
	void Update(){
		if(Selected){
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			if (Input.GetButtonDown("Jump"))
			{
				jump = true;
			}
		}
		isSelected();
	}

	void FixedUpdate(){
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
		
	}

	public void isSelected(){
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			if(personagem == 1){
				gameObject.GetComponent<BoxCollider2D>().enabled = true;
				gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
				Selected = true;
			}else{
				gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
				gameObject.GetComponent<BoxCollider2D>().enabled = false;
				Selected = false;
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			if(personagem == 2){
				gameObject.GetComponent<BoxCollider2D>().enabled = true;
				gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
				Selected = true;
			}else{
				gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
				gameObject.GetComponent<BoxCollider2D>().enabled = false;
				Selected = false;
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha3)){
			if(personagem == 3){
				gameObject.GetComponent<BoxCollider2D>().enabled = true;
				gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
				Selected = true;
			}else{
				gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
				gameObject.GetComponent<BoxCollider2D>().enabled = false;
				Selected = false;
			}
		}
	}





	



	


}






/*

if(Input.GetKeyDown(KeyCode.Alpha1)){
			if(personagem == 1){
				Selected = true;
			}else if(personagem == 2){
				Selected = true;
			}else if(personagem == 3){
				Selected = true;
			}else{
				Selected = false;
			}
		}

*/
