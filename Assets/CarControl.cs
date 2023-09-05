using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    Rigidbody physical;
    public float speed;



    void Start()
    {



    }
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Vertical"), -1f, 0f);
        transform.position += movement * Time.deltaTime * speed;


    }

}