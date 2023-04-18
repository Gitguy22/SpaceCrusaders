using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappySpace : MonoBehaviour
{

    Rigidbody2D ship;
    // Start is called before the first frame update
    void Start()
    {
        ship = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           ship.AddForce(new Vector2(0,1) * 500);   
        }
    }
}
