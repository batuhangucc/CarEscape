using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{

    private CharControl Speed;

    void Start()
    {
        Speed = FindObjectOfType<CharControl>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Speed"))
        {
            Destroy(collider.gameObject);
            SpeedUpp();
            Invoke("StopSpeedUp", 3);


        }

    }

    void Update()
    {

    }
    private void SpeedUpp()
    {
        Speed.moveSpeed = 4f;
    }
    private void StopSpeedUp()
    {
        Speed.moveSpeed = 2;

    }
}
