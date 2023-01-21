using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject player; 



    void OnTriggerEnter()
    {
        PlayerTrigger trigger = player.GetComponent<PlayerTrigger>();
        Debug.Log(trigger.currentOy);
        if (trigger.currentOy>=51)
        {
            gameManager.CompleteLevel();

        }
        else
        {
            gameManager.FailedLevelUI();
        }
    }

}
