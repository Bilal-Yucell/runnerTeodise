using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public PlayerMov movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "End")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
    
}
