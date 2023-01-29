using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Color defaultColor;
    public Color collisionColor;

    public PlayerMovement  playerMovement;

    public Renderer rend;

    public int collisionCount;


    private void Start()
    {
        collisionCount = 0;
        rend = GetComponent<Renderer>();
        defaultColor = rend.material.color;
    }

    void OnCollisionStay(Collision collision) {
        if(collision.collider.tag == "obstacles"){
            rend.material.color = new Color(250, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacles")
        {
            collisionCount++;
            rend.material.color = new Color(250, 0, 0);
            Debug.Log("Collision count : "+collisionCount);
            playerMovement.enabled = false;
        }
    }
/*
    private void OnCollisionExit(Collision collision){
        rend.material.color = defaultColor;
    }
*/
}
