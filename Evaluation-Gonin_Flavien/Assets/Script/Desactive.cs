using System;
using UnityEngine;

public class Desactive : MonoBehaviour
{
	private void Start()
	{
		Show(false);
	}

	public void Show(bool show)
	{
		gameObject.SetActive(show);
	}
}