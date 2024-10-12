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
    public float minY = -16f;
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

        Vector3 currentPosition = transform.position;
        if(currentPosition.y < minY)
        {
            logic.gameOver();
            birdIsAlive = false;
        }  
        if(Input.GetKeyDown(KeyCode.R) == true)
        {
            logic.restartGame();
        }  
        if(birdIsAlive != true)    
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
