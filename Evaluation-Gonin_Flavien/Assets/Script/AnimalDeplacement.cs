using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AnimalDeplacement : MonoBehaviour
{
	[HideInInspector]
	public Vector3 direction;
	
	private Rigidbody rb;
	private List<Vector3> directions = new();
	
	[HideInInspector]
	public bool canMove = true;
	[HideInInspector]
	public bool inEnclos = false;
	[HideInInspector]
	public GameObject follow = null;
	[HideInInspector]
	public int c = 0;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		directions.Add(Vector3.forward);
		directions.Add(Vector3.back);
		directions.Add(Vector3.right);
		directions.Add(Vector3.left);
		
		direction = directions[Random.Range(0, directions.Count)];
	}

	private void FixedUpdate()
	{
		//Si l'animal est dans l'enclos on ne bouge plus
		if (inEnclos)
		{
			transform.position = new(-11f + 2 * c, 0, 1.2f);
			return;
		}

		if (!canMove && follow != null)
		{
			//Instruction pour que l'animal suive le joueur
			rb.MovePosition(rb.position + follow.GetComponent<Deplacement>().movementHorizontal + follow.GetComponent<Deplacement>().movementVertical);
			if (transform.position.z <= -1 || transform.position.z >= 16 || transform.position.x <= -11 || transform.position.x >= 11)
			{
				if(gameObject.CompareTag("B"))
					Destroy(gameObject);
			}
			return;
		}

		if (!canMove)
			return;
		
		//Deplace le gameObject
		if((direction.z < 0 && transform.position.z > -1) || (direction.z > 0 && transform.position.z < 16) 
		    || (direction.x < 0 && transform.position.x > -11) || (direction.x > 0 && transform.position.x < 11))
			rb.MovePosition(rb.position + Time.deltaTime * 3f * direction);

		//Verifie la position du gameObject pour changer sa direction
		if (transform.position.z <= -1)
		{
			direction = directions[Random.Range(0, directions.Count)];
		}else if (transform.position.z >= 16)
		{
			direction = directions[Random.Range(0, directions.Count)];
		}

		if (transform.position.x <= -11)
		{
			direction = directions[Random.Range(0, directions.Count)];
		}else if (transform.position.x >= 11)
		{
			direction = directions[Random.Range(0, directions.Count)];
		}
	}
}