using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckGround : MonoBehaviour {

    private P_Movement player;
    


	// Use this for initialization
	void Start () {

        player = GetComponentInParent<P_Movement>();
	}

     void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            player.grounded = true;
        }
    }

     void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            player.grounded = false;
        }

        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coins")
        {
            Debug.Log("hola");
            Score.scoreValue = Score.scoreValue + 1;
        }
    }
}
