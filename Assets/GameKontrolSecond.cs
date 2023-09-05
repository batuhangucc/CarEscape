using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameKontrolSecond : MonoBehaviour
{
    public GameObject[] Prefabs;
    public float secondSpawn = 8f;
    public float minTrans;
    public float maxTrans;
    public float firstSpawn = 5.0f;
    int x = 1;
    public float speed = 1f;
    public float startSpeed;
    public ScoreManager sManager;
    public bool Stop;
    void Start()
    {


        StartCoroutine(CarSpawn());

    }
    void Update()
    {

    }


    IEnumerator CarSpawn()
    {
        for (int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(firstSpawn);
        }

        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y, transform.position.z);
            var gameobject = Instantiate(Prefabs[Random.Range(0, Prefabs.Length)], position, Quaternion.identity).GetComponent<CarControl>();
            gameobject.speed += startSpeed;
            yield return new WaitForSeconds(secondSpawn);
        }
    }
    private void Awake()
    {
        sManager = FindObjectOfType<ScoreManager>();
        sManager.OnIncrease += Name;

    }
    private void Name()
    {
        startSpeed += 0.2f;
        secondSpawn = 5f;
    }
    private void OnDestroy()
    {
        sManager.OnIncrease -= Name;
    }


}
