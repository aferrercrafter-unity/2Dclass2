using UnityEngine;

public class Ball : MonoBehaviour
{
	
	void Start () {
	
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			transform.parent.DetachChildren ();
		}

	//	transform.SetParent ();
	}
}
