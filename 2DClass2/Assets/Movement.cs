using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed = 0;
    float movx;

	// Use this for initialization
	void Start () {
	
	}

    // Fixed Update 
    void FixedUpdate(){

        movx = Input.GetAxisRaw("Horizontal");
        if (movx > 0)
        {
            var posx = transform.position.x;

            if (Camera.main.WorldToViewportPoint(new Vector3(posx + 1  , 0, 0)).x >= 1)
                movx = 0;
        }
        if (movx < 0)
        {
            var posx = transform.position.x;

            if (Camera.main.WorldToViewportPoint(new Vector3(posx - 1, 0, 0)).x <= 0)
                movx = 0;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.right * movx * speed * Time.deltaTime);
	}
}
