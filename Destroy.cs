using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class: Destroy : MonoBehaviour
{
	void OnCollisionCapture(Collision collision)
	{
		if (collision.gameObject.tag == "chess")
		{
			Destroy(collision.gameObject);
		}
	}
}
