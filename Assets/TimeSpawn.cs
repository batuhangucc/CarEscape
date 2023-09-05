using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpawn : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float secondSpawn = 15;
    public float minTrans;
    public float maxTrans;
    public float startSpeed;
    private float firstSpawn = 5;
    int x = 5;
    void Start()
    {
        StartCoroutine(TimeSpawnn());
    }


    IEnumerator TimeSpawnn()
    {
        for (int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(firstSpawn);
        }
        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector2(wanted, -4);
            var gameobject = Instantiate(Prefabs[Random.Range(0, Prefabs.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
        }
    }
    void Update()
    {

    }
}
