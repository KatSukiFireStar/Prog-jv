using System;
using UnityEngine;

public class ChangeSizeOnTrigger : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "joueur")
		{
			other.transform.localScale *= 1.5f;
			Destroy(gameObject);
		}
		
	}
}