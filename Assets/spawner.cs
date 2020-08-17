using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour{
    public BoxCollider2D normal;
    public Larva inimigo;
    public RectTransform pos;
    public GameObject Game;
    public float x,y;


    void Awake(){
        pos = GetComponent<RectTransform>();
        x = pos.localPosition.x;
        y = pos.localPosition.y;
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        //Instantiate(inimigo, new Vector2(pos.localPosition.x, pos.localPosition.x), Quaternion.identity);
        //inimigo.transform.parent = GameObject.Find("Game").transform;
        //GameObject childGameObject = new GameObject("childGameObject");
        //childGameObject.transform.SetParent(transform);
        //inimigo.collider.transform.SetParent(Game.transform);

        //Larva enemy = new Larva();
        //Instantiate(inimigo, new Vector2(x, y), Quaternion.identity);
        //enemy.GetComponent<Collider>().transform.SetParent(Game.transform);




    

    }
    


    
}
