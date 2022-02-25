using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private GameObject gameObjectFoundBySearch; 

    void OnTriggerEnter2D(Collider2D other) {
        
        gameObjectFoundBySearch = GameObject.Find("Logo");       
        
        var animator = gameObjectFoundBySearch.GetComponent<Animator>(); 
        animator.SetBool("isComplete", true); 
        Debug.Log("Completo");  
    }
}
