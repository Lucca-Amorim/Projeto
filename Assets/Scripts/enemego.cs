using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public abstract class enemego : MonoBehaviour{
    public SpriteRenderer fota;
    private float xDele, yDele;
    public float remapagosMarquinhos;
    protected bool direita = false;
    public static int vida = 10;

    void Awake(){
        fota = GetComponent<SpriteRenderer>();
    }


    void Start(){
        xDele = transform.position.x;
        yDele = transform.position.y;
    }

    void LateUpdate(){
        cuidaDeAndar();
        
    }
    private void cuidaDeAndar(){
        transform.position = new Vector3(xDele, transform.position.y, transform.position.z);
        if(direita){
            xDele += remapagosMarquinhos;
        }else if(!direita){
            xDele -= remapagosMarquinhos;
        }
    }
    private void trocaLado(){
        fota.flipX = !fota.flipX;
        direita = !direita;
    }

    void OnCollisionEnter2D(Collision2D collision){
        if((collision.gameObject.layer == Layers.blocksLayer) || 
        (collision.gameObject.layer == Layers.limitesLayerParede) || 
        (collision.gameObject.layer == Layers.triggersLayer)){
            trocaLado();
        }
        if(collision.gameObject.layer == Layers.playersLayer){
            //trocaLado();
        }
    }
    
}
