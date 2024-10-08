using System;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
	[SerializeField]
	private int posZToDestroy;

	private void Update()
	{
		if (transform.position.z >= posZToDestroy)
		{
			Destroy(gameObject);
		}
	}

	
}