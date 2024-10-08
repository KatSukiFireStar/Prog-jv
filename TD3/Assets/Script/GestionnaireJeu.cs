using System;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
	CoffreVoiture coffreVoiture;
	CoffreVoiture coffreVoiture2;

	private void Start()
	{
		coffreVoiture = new();
		coffreVoiture2 = new(5);
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.D))
		{
			coffreVoiture = null;
			coffreVoiture2 = null;
		}
	}
}