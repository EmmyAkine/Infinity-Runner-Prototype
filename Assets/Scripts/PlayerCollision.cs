using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameManagerScript gameManagerScript;
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
       if ( collisionInfo.collider.tag == "Obstacle" )
       { 
        playerMovement.StopPlayer();
        playerMovement.enabled = false;
        gameManagerScript.GameOver();
      //  transform.position = originalPosition;
       }
    }

    private void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            
            gameManagerScript.GameOver();
            playerMovement.StopPlayer();
           // transform.position = originalPosition;
            playerMovement.enabled = false;
        }

    }
}
