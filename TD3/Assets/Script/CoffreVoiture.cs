using UnityEngine;

public class CoffreVoiture
{
	public CoffreVoiture()
	{
		Debug.Log("Coffre de voiture crée");
	}

	public CoffreVoiture(int size)
	{
		Debug.Log("Coffre de voiture crée avec l'argument: " + size);
	}

	~CoffreVoiture()
	{
		Debug.Log("Le coffre de la voiture sera maintenant détruit!");
	}
}