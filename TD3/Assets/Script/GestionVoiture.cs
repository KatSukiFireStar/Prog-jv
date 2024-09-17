using UnityEngine;

public class GestionVoiture
{
	private double essence;

	public double Essence
	{
		get => essence;
		set => essence = value;
	}

	public GestionVoiture()
	{
		this.essence = 10;
		Debug.Log("Essence : " + essence);
	}

	public bool roule(double consommation)
	{
		essence -= consommation;
		return essence > 0;
	}
}