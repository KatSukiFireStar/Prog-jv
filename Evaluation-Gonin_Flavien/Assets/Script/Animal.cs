using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Animal : MonoBehaviour
{
	
	private void OnTriggerEnter(Collider other)
	{
		//Regarde si l'objet en collision est un joueur et si oui ajoute l'energie a ou b au personnage
		if (other.CompareTag("Enclos") && !gameObject.CompareTag("B"))
		{
			if (!gameObject.GetComponent<AnimalDeplacement>().canMove)
			{
				gameObject.GetComponent<AnimalDeplacement>().inEnclos = true;
				gameObject.GetComponent<AnimalDeplacement>().c = other.transform.childCount;
				transform.parent = other.transform;
			}
		}else if (other.CompareTag("Player") && !gameObject.GetComponent<AnimalDeplacement>().inEnclos)
		{
			if (gameObject.CompareTag("A"))
			{
				if (other.GetComponent<Player>().hadEnergieA)
				{
					gameObject.GetComponent<AnimalDeplacement>().canMove = false;
					gameObject.GetComponent<AnimalDeplacement>().follow = other.gameObject;
					other.GetComponent<Player>().hadEnergieA = false;
					other.GetComponent<Player>().NotBanana();
				}
				else
				{
					EndGame();
				}
			}
			else if (gameObject.CompareTag("B"))
			{
				if (other.GetComponent<Player>().hadEnergieB)
				{
					gameObject.GetComponent<AnimalDeplacement>().canMove = false;
					gameObject.GetComponent<AnimalDeplacement>().follow = other.gameObject;
					other.GetComponent<Player>().hadEnergieB = false;
					other.GetComponent<Player>().GrowDown();
				}
				else
				{
					EndGame();
				}
			}
		}
	}

	private void EndGame()
	{
		transform.parent.GetComponent<Spawner>().canSpawn = false;
		GameObject.Find("FruitSpawner").GetComponent<Spawner>().canSpawn = false;
		GameObject.Find("Farmer").GetComponent<Deplacement>().canMove = false;
		foreach (Transform t in transform.parent)
		{
			t.GetComponent<AnimalDeplacement>().canMove = false;
		}
		GameObject.Find("Canvas").transform.GetChild(0).GetComponent<Desactive>().Show(true);
	}
}