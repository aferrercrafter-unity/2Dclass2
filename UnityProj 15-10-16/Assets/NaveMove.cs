using UnityEngine;

public class NaveMove : MonoBehaviour
{
	void Update ()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		transform.Translate (Time.deltaTime * 5 * h,
						 	 Time.deltaTime * 5 * v, 
							 0);
	}
}
