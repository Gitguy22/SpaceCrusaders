using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlappySpace : MonoBehaviour
{

    Rigidbody2D ship;

    int score = 0;

    public bool isAlive;

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        ship = GetComponent<Rigidbody2D>();

        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           ship.AddForce(new Vector2(0,1) * 150);   
        }
    }

    //Executes code everytime you enter the trigger
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
            //increase score by one point
            score = score + 1;

            scoreText.text = score.ToString();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        isAlive = false;
    }
}
