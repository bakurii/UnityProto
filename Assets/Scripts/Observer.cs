using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Observer : MonoBehaviour
{
    //Collider to check if player and the game object are close enough to interact.
    public bool distanceToThePlayer = false;

    public void OnTriggerEnter(Collider other)
    {
        GameObject icon = GameObject.Find("DialogueIcon");
        ReactionIcon reactionIcon = icon.GetComponent<ReactionIcon>();

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("OSUISUOSUOSISOI");
            distanceToThePlayer = true;
            reactionIcon.dialogueIcon.enabled = true;
        }
    }


    public void OnTriggerExit(Collider other)
    {
        GameObject icon = GameObject.Find("DialogueIcon");
        ReactionIcon reactionIcon = icon.GetComponent<ReactionIcon>();

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Sopivan kaukana");
            distanceToThePlayer = false;
            reactionIcon.dialogueIcon.enabled = false;
        }
    }
}
