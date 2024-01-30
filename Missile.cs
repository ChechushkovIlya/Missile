using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{ 
  
    public float speed;

    void Start()
    {
       Destroy (gameObject, 3);
    }

    void Update()
    {
         transform.position += transform.forward*speed* Time.deltaTime;
    }
     
    private void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject .tag.Equals("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
    

}
