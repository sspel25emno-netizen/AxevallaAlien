using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject enemyship;
    private int enemyCounter;
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

        while (true)
        {


            if (enemyCounter < 3 && GameObject.Find("player") != null)
            {

                Instantiate(enemyship, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);

                enemyCounter++;
                yield return new WaitForSeconds(5);

            }
            else yield return null;
        }
    }
    



    




}
