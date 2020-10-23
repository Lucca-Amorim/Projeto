using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class enemego : MonoBehaviour{
    SpriteRenderer fota;
    private float xDele, yDele;
    public float remapagosMarquinhos;
    protected bool direita = true;
    public int vida;

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
    public void cuidaDeAndar(){
        transform.position = new Vector3(transform.position.x + remapagosMarquinhos, transform.position.y, transform.position.z);
        if(vida <= 0){
            GameObject.Destroy(this.gameObject);
        }
    }
    private void trocaLado(){
        fota.flipX = !fota.flipX;
        direita = !direita;
        remapagosMarquinhos = -1 * remapagosMarquinhos;
    }

    void OnCollisionEnter2D(Collision2D collision){
        if((collision.gameObject.layer == Layers.limitesLayerParede) || 
        (collision.gameObject.layer == Layers.triggersLayer)){
            trocaLado();
            SoundManagerScript.PlaySound("trocaLado");

        }
        if(collision.gameObject.layer == Layers.playersLayer){
            //trocaLado();
        }
    }

    public void tiraVd(int dano){
        vida -= dano;
        if(vida <= 0){
            GameObject.Destroy(this.gameObject);
        }
    }
    
}
