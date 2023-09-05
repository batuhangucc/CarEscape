using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameKontrol : MonoBehaviour
{
    public GameObject[] Prefabs;
    public float secondSpawn = 5f;
    public float minTrans;
    public float maxTrans;
    public float startSpeed;
    public ScoreManager sManager;
    public bool Stop = true;


    void Start()
    {
        StartCoroutine(CarSpawn());
    }

    IEnumerator CarSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector2(wanted, transform.position.y);
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
        secondSpawn = 3f;
    }
    private void OnDestroy()
    {
        sManager.OnIncrease -= Name;
    }
}
