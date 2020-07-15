using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour{
    public float Speed;
    void Start () {

    }
    
     // Update is called once per frame
    void Update () {

    if (Input.GetKey(KeyCode.W)){
        transform.position += transform.up * Speed * Time.deltaTime;
        }
    else if (Input.GetKey(KeyCode.S)){
        transform.position -= transform.up * Speed * Time.deltaTime;
        }
 
    if (Input.GetKey(KeyCode.D)){
        transform.position += transform.right * Speed * Time.deltaTime;
        }
    else if (Input.GetKey(KeyCode.A)){
        transform.position -= transform.right * Speed * Time.deltaTime;
        }
    }
}
