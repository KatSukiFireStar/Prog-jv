using System;
using UnityEngine;

public class DeplaceObjet : MonoBehaviour
{
	[SerializeField] 
	private float vitesse = 5f;
	
	[SerializeField]
	private Spawner spawner;

	private void Start()
	{
		if(gameObject.CompareTag("Obstacle"))
			spawner = transform.parent.GetComponent<Spawner>();
	}

	private void Update()
	{
		if(spawner.gameOver && gameObject.CompareTag("Obstacle"))
			Destroy(gameObject);
		
		if (spawner.gameOver)
			return;
		
		transform.Translate( vitesse * Time.deltaTime * Vector3.left);

		if (transform.position.x < -12f)
		{
			Destroy(gameObject);
		}
	}
}