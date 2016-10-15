using UnityEngine;
using System.Collections;

public class SideForce : MonoBehaviour
{

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {        
        if (col.gameObject.CompareTag("Paddle"))
        {
                rb.AddForce(new Vector2(transform.position.x - col.gameObject.transform.position.x, 0.0f), ForceMode2D.Impulse);
        }
    }
}
