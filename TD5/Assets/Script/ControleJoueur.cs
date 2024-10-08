using System;
using UnityEngine;
using UnityEngine.UIElements;

public class ControleJoueur : MonoBehaviour
{

	[SerializeField] 
	private int speed;

	[SerializeField] 
	private GameObject bullet;
	
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
		
		if (Input.GetKey(KeyCode.Q))
		{
			if (transform.position.x > -11)
			{
				transform.Translate( speed * Time.deltaTime * Vector3.left, Space.World);
			}
		}else if (Input.GetKey(KeyCode.D))
		{
			if (transform.position.x < 11)
			{
				transform.Translate(speed * Time.deltaTime * Vector3.right, Space.World);
			}
		}
	}

	private void Shoot()
	{
		Instantiate(bullet, transform.position + Vector3.up , bullet.transform.rotation);
	}
}