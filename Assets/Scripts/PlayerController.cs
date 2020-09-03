using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    float speed = 10.0f;
    float turnSpeed = 80.0f;
    float horizontalInput;
    float forwardInput;
    bool runningInput;
    bool reactionInput;

    void Update()
    {
        //player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //movement for the player by changing its transorm Translate xyz values for moving forward. And Rotation values for turning.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        RunningPlayer();
        PlayerReaction();
    }

    //Z is ther running button, while it is pressed down player movement speed value and rotation speed is higher
    bool RunningPlayer()
    {
        runningInput = Input.GetKey("z");

        if (runningInput)
        {
            speed = 30f;
            turnSpeed = 100.0f;
        }

        else
        {
            speed = 10.0f;
            turnSpeed = 80.0f;
        }

        return runningInput;
    }

    //player reactoin button is space button
    //if player is near an item or a npc, by pressing space player can interact with them.
    public bool PlayerReaction()
    {
        reactionInput = Input.GetKeyDown("space");

        //if (reactionInput)
        //{
        //    Debug.Log("Sapcepainettu mahtavaaa");
        //}

        return reactionInput;
    }


}
