using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class force : MonoBehaviour{
    public float Speed;
    //public CollisionInfo collisions;
    //private const int LIMITES_LAYER = 12;
    //public LayerMask collisionMask;
    void Start () {

    }
    
     // Update is called once per frame
    void Update () {

    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
        transform.position += transform.up * ((float)(Speed/1.3)) * Time.deltaTime;
        }
    else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
        transform.position -= transform.up * ((float)(Speed/1.3)) * Time.deltaTime;
        }
 
    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
        transform.position += transform.right * Speed * Time.deltaTime;
        }
    else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
        transform.position -= transform.right * Speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("ta indo?");
    }
}
