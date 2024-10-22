using UnityEngine;

public class Player : MonoBehaviour
{
	[HideInInspector]
	public bool hadEnergieA = false;
	[HideInInspector]
	public bool hadEnergieB = false;

	public void Banana()
	{
		transform.GetChild(0).gameObject.SetActive(true);
	}

	public void NotBanana()
	{
		transform.GetChild(0).gameObject.SetActive(false);
	}
	
	public void GrowUp()
	{
		transform.localScale += new Vector3(1f, 1f, 1f);
	}

	public void GrowDown()
	{
		transform.localScale -= new Vector3(1f, 1f, 1f);
	}
}