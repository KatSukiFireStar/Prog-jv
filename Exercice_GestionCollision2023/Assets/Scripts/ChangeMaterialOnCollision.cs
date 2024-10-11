using System;
using UnityEngine;

public class ChangeMaterialOnCollision : MonoBehaviour
{
	[SerializeField]
	private Material newMaterial;
	[SerializeField]
	private Material baseMaterial;

	public void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "joueur")
		{
			if(other.gameObject.transform.localScale.x <= 1)
				GetComponent<MeshRenderer>().material = newMaterial;
			else
			{
				Destroy(gameObject);
			}
		}
		
	}

	private void OnCollisionExit(Collision other)
	{
		if (other.gameObject.name == "joueur")
			GetComponent<MeshRenderer>().material = baseMaterial;
	}
}