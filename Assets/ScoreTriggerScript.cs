using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        //Locate the logic object and the script
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.layer == 3) 
        {
            logic.addScore(1);
        }
    }
}
