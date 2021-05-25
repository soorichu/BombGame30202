using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float translation;
    private float rotation;

    public float tspeed = 10f;
    public float rspeed = 100f;

    private Animator ani;
    private void Start() 
    { 
        ani = GetComponent<Animator>(); 
    }
    void Update()
    {
        translation = Input.GetAxis("Vertical") * tspeed;
        rotation = Input.GetAxis("Horizontal") * rspeed;

        transform.Translate(0, 0, translation * Time.deltaTime);
        transform.Rotate(0, rotation * Time.deltaTime, 0);

        if (translation != 0 || rotation != 0) 
        { 
            ani.SetBool("walk", true); 
        } 
        else 
        {
            ani.SetBool("walk", false); 
        }
    }

    private void OnCollisionEnter(Collision collision) 
    { 
        if (collision.collider.tag == "Obstacle") 
        { 
            ani.SetTrigger("damage"); 
        } 
    }

}
