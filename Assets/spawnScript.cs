using System.Collections;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject enemyship;
    private int enemycounter;
    private GameObject player;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemySpawner()
    {


        yield return null;
    }
}
