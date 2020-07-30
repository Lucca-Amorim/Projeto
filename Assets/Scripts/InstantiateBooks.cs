using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBooks : MonoBehaviour
{   
    public GameObject emptyGameObjectPrefab;
    public int livros;
    
    void Start(){
        
        for(int y = 0; y < livros; y++){
            var Livro = Instantiate(emptyGameObjectPrefab, (new Vector3(transform.position.x, transform.position.y, transform.position.z)), Quaternion.identity);    
            Livro.transform.parent = gameObject.transform;
            Livro.transform.localScale = new Vector3((float)0.69409,(float)0.69409,(float)0.69409);
        }
    }


}
//Vector3(transform.position.x,transform.position.y, transform.position.z)