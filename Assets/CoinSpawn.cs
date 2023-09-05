using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float secondSpawn = 10;
    public float minTrans;
    public float maxTrans;
    private float startSpeed;
    private float firstSpawn;
    int x = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawnn());
    }

    IEnumerator CoinSpawnn()
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
