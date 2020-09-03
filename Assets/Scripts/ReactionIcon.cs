using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactionIcon : MonoBehaviour
{
    public Image dialogueIcon;
    bool reactionInput = false;

    void Start()
    {
        dialogueIcon = GameObject.Find("DialogueIcon").GetComponent<Image>();
        //dialogueIcon.enabled = false;
    }

    void Update()
    {
        ReactionButton();
        ShowAndHideIcon();
    }

    public void ShowAndHideIcon()
    {
        //Chacks if the value of the distanceToThePlayer is true or false, and by that enables or disables the dialogueIcon.
        GameObject observer = GameObject.Find("Observer");
        Observer observerScript = observer.GetComponent<Observer>();

        if (!observerScript.distanceToThePlayer)
        {
            //Debug.Log("Distance to the player" + observerScript.distanceToThePlayer);
            //dialogueIcon.enabled = false;
        }

        if (observerScript.distanceToThePlayer)
        {
            Debug.Log("Distance to the player" + observerScript.distanceToThePlayer);
            Debug.Log("MAHTAVAAA SE TOIMIIIIIIIIIII");
            //dialogueIcon.enabled = true;
        }
    }


    bool ReactionButton()
    {
        //Access to the PlayerController script to check if the Space button is pressed down.
        GameObject player = GameObject.Find("Player");
        PlayerController playerControllerScript = player.GetComponent<PlayerController>();

        if(playerControllerScript.PlayerReaction() == true)
        {
            reactionInput = true;
            Debug.Log("Spacepainettu jibbiii");
            if (reactionInput)
            {
                
            }
        }

        else
        {
            reactionInput = false;
        }

        return reactionInput;
    }
}
