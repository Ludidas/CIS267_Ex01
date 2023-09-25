using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int collectableValue;
    //we need a reference to the PlayerScore.cs script. That script is attached to the player
    public GameObject playerObject;
    private PlayerScore gameScore;
    // Start is called before the first frame update
    void Start()
    {
        //Find the object that has the PlayerScore.cs script attached to it.
        //You can use .find but should avoid if you can.
        //By making the playerObject variable public we can use Unity editor to link the variable with the object
        //This will allow us to access the script.

        //can do this but not required at this time
        //This will search for the entire heirarchy until if finds an object called player
        //playerObject = GameObject.Find("Player");

        //cannot just use GetComponent because PlayerScore.cs is not attached to the collectable
        gameScore=playerObject.GetComponent<PlayerScore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gameScore.setPlayerScore(collectableValue);
            Destroy(this.gameObject);

            Console.Write(gameScore);
        }

    }
}
