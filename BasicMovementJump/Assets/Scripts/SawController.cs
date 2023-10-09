using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SawController : MonoBehaviour
{
    public float movementSpeed;
    public float offset;
    private bool moveUp;
    private float startPositionY;

    // Start is called before the first frame update
    void Start()
    {
        moveUp = false;
        startPositionY=transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        moveSaw();

    }

    public void moveSaw()
    {
        if(moveUp)
        {
            //move the saw up
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
        }
        else
        {
            //move the saw down
            transform.Translate(Vector2.down * movementSpeed * Time.deltaTime);
        }

        //determine if the saw needs to move up or down

        if(transform.position.y <= startPositionY-offset)
        {
            moveUp=true;
        }
        else if (transform.position.y >= startPositionY)
        {
            moveUp = false;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Dead");
        }
    }

}
