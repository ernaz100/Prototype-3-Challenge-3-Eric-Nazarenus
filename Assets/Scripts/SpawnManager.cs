using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawningObject;
    private Vector3 spawnPosition = new Vector3(20, 0, 0);
    private float startDelay = 2f;
    private float repeatInterval = 3f;
    private PlayerController playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnMethod", startDelay, repeatInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnMethod()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(spawningObject, spawnPosition, spawningObject.transform.rotation);
        }
    }
}
