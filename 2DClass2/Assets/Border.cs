using UnityEngine;
using System.Collections;

public class Border : MonoBehaviour {

    SpriteRenderer sr;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (rb.velocity.y >= 1)
        {
            //print(rb.velocity.y);
            Vector3 max_scale = Camera.main.WorldToViewportPoint(sr.bounds.max);

            if (max_scale.y >= 1)
            {
                Vector3 max_real = Camera.main.ViewportToWorldPoint(new Vector3(0, max_scale.y, 0));
                transform.Translate(new Vector3(transform.position.x, max_real.y - sr.bounds.extents.y, transform.position.z));
                rb.velocity.Set(rb.velocity.x, -rb.velocity.y);
                //print("Entro");
            }
        }
        /*
        if (rb.velocity.x >= 1)
        {
            print(rb.velocity.x);
            if (Camera.main.WorldToViewportPoint(sr.bounds.max).x > 1)
                rb.velocity.Set(-rb.velocity.x, rb.velocity.y);
        }
        if (rb.velocity.x <= 0)
        {
            print(rb.velocity.x);
            if (Camera.main.WorldToViewportPoint(sr.bounds.max).x <= 0.0f)
                rb.velocity.Set(-rb.velocity.x, rb.velocity.y);
        }
        */
        
        /*
        if (rb.velocity.y <= 0)
        {
            print(rb.velocity.y);
            if (Camera.main.WorldToViewportPoint(sr.bounds.max).y <= 0)
            {
                rb.velocity.Set(rb.velocity.x, rb.velocity.y);
                print("");
            }
                
        }
         * */


	}
}
