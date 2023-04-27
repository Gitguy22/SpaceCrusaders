using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;

    FlappySpace shipScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PipeSpawner", 0.5f, 3);
        shipScript = GameObject.Find("PlayerOne").GetComponent<FlappySpace>();
    }

    // Update is called once per frame
    void Update()
    {
        if(shipScript.isAlive == false)
        {
            CancelInvoke();
        }
    }
    void PipeSpawner()
    {
       Instantiate( pipePrefab, new Vector2(10, Random.Range(-3.42f, 9.84f)), Quaternion.identity); 
    }
}
