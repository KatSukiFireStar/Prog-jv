using System;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Food : MonoBehaviour
{
	private float timmer = 15f;

	private void Update()
	{
		timmer -= Time.deltaTime;
		
		if(timmer <= 0)
			Destroy(gameObject);
	}

	private void OnTriggerEnter(Collider other)
	{
		//Regarde si l'objet en collision est un joueur et si oui ajoute l'energie a ou b au personnage
		if (other.CompareTag("Player"))
		{
			if (gameObject.CompareTag("A"))
			{
				other.GetComponent<Player>().hadEnergieA = true;
				other.GetComponent<Player>().Banana();
			}else if (gameObject.CompareTag("B") && !other.GetComponent<Player>().hadEnergieB)
			{
				other.GetComponent<Player>().hadEnergieB = true;
				other.GetComponent<Player>().GrowUp();
			}
			Destroy(gameObject);
		}
	}
}