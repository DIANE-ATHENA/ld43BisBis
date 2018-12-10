using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("z"))
        {
            gameObject.GetComponent<Transform>().position = new Vector2(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y + 1);
        }
	
        if (Input.GetKey("s"))
        {
            gameObject.GetComponent<Transform>().position = new Vector2(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y - 1);
        }

        if (Input.GetKey("q"))
        {
            gameObject.GetComponent<Transform>().position = new Vector2(gameObject.GetComponent<Transform>().position.x - 1, gameObject.GetComponent<Transform>().position.y);
        }

        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Transform>().position = new Vector2(gameObject.GetComponent<Transform>().position.x + 1, gameObject.GetComponent<Transform>().position.y);
        }
     
	}


}
