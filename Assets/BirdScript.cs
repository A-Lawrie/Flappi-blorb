using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicManegerScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        //reference the logic script from a different game object
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManegerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
