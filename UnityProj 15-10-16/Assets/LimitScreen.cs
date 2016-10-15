using UnityEngine;

public class LimitScreen : MonoBehaviour
{
	private SpriteRenderer rend;

	void Awake ()
	{
		rend = GetComponent<SpriteRenderer> ();
	}

	void Update ()
	{
		
		Vector3 maxInViewport = Camera.main.WorldToViewportPoint(rend.bounds.max);

		float posMaxX = Mathf.Min(maxInViewport.x, 1.0f);

		Vector3 posMaxInWorld = Camera.main.ViewportToWorldPoint(new Vector3(posMaxX, 0, 0));

		transform.position = new Vector3 (posMaxInWorld.x - rend.bounds.extents.x,
											transform.position.y, 
											transform.position.z);
	}
}
