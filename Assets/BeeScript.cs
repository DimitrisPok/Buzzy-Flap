using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public shake ShakeScript;

    public float flapStrength;
    public bool beeIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        //Locate the camera object and the script
        ShakeScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<shake>();
        //Locate the logic object and the script
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && beeIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > 1 || transform.position.y < -1)
        {
            logic.gameOver();  //making the game over screen appear when the bee goes out of bounds
            beeIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver(); //making the game over screen appear when collision occurs
        beeIsAlive = false;
        StartCoroutine(ShakeScript.Shaking());
    }

}
