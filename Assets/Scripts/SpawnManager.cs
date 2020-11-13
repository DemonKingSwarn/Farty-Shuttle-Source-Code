using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject pipesPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2, 2);
    }

    // SpawnPipes at 2 second intervals
    void SpawnPipes()
    {
        //Only spawn if game is not over
        if(!GameManager.Instance.gameOver)
            Instantiate(pipesPrefab, new Vector3(pipesPrefab.transform.position.x, pipesPrefab.transform.position.y + Random.Range(-2.5f,2.5f), pipesPrefab.transform.position.z), Quaternion.identity);
    }
}
