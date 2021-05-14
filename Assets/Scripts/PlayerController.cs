using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float translation;
    private float rotation;

    public float tspeed = 10f;
    public float rspeed = 100f;
    void Update()
    {
        translation = Input.GetAxis("Vertical") * tspeed;
        rotation = Input.GetAxis("Horizontal") * rspeed;

        transform.Translate(0, 0, translation * Time.deltaTime);
        transform.Rotate(0, rotation * Time.deltaTime, 0);
    }
}
