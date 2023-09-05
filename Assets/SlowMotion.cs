using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{

    private CharControl slow;

    void Start()
    {
        slow = FindObjectOfType<CharControl>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Sand"))
        {
            Destroy(collider.gameObject);
            StartSlowMotion();
            Invoke("StopSlowMotion", 3);


        }

    }

    void Update()
    {

    }
    private void StartSlowMotion()
    {
        slow.moveSpeed = 0.1f;
    }
    private void StopSlowMotion()
    {
        slow.moveSpeed = 2;

    }
}
