using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SpawnScript : MonoBehaviour
{
    
    public Transform[] spawnPoints;
    public GameObject[] balloon;

    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(3);

        // for(int i=0; i<3; i++)
        // {
        //     Instantiate(balloon[i], spawnPoints[i].position, Quaternion.identity);
        // }
        // StartCoroutine(StartSpawning());

        int i = Random.Range(0, balloon.Length);
        int j = Random.Range(0, spawnPoints.Length);

        Instantiate(balloon[i], spawnPoints[j].position, Quaternion.identity);
        StartCoroutine(StartSpawning());

    }

}
