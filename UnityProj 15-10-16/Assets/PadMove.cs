using UnityEngine;
using System.Collections;

public class PadMove : MonoBehaviour
{
	void Update ()
	{
		float v = Input.GetAxisRaw ("Vertical");

		transform.Translate (0, v * Time.deltaTime * 10, 0);
	}
}
