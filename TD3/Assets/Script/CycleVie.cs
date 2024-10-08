using System;
using UnityEngine;

public class CycleVie : MonoBehaviour
{
	private CoffreVoiture coffreVoiture;
	
	private void Awake()
	{
		Debug.Log("La voiture se réveille");
		coffreVoiture = new CoffreVoiture();
	}

	private void Start()
	{
		Debug.Log("La voiture finit son paramétrage juste avant son utilisation");
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Destroy(this);
		}
	}

	private void OnDestroy()
	{
		Debug.Log("La voiture est en voie de destruction");
	}
}