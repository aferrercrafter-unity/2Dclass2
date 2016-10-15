using UnityEngine;
using System.Collections;

public class Rebote : MonoBehaviour {

	private Rigidbody2D rb;

	void Awake () {
	
		rb = GetComponent<Rigidbody2D> ();

	}
		
	void Update () {
	
		if (Input.anyKeyDown) {

			rb.AddForce (Random.insideUnitCircle * 20, ForceMode2D.Impulse);

		}

	}
}
