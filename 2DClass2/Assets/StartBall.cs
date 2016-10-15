using UnityEngine;
using System.Collections;

public class StartBall : MonoBehaviour {

    public float start_force = 10;
    Rigidbody2D rb;
    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector2.up * start_force, ForceMode2D.Impulse);
            Destroy(GetComponent<Movement>());
            Destroy(this);
        }
            

	}
}
