using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManegerScript logic;
    // Start is called before the first frame update
    void Start()
    {
        //reference the logic script from a different game object
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManegerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
        logic.addScore(1);
        }
    }
}
