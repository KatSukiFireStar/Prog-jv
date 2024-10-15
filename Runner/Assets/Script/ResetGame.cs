using UnityEngine;

public class ResetGame : MonoBehaviour
{
	[SerializeField] 
	private Spawner spawner;
	
	[SerializeField] 
	private ControlePersonnage controlePersonnage;
	
	[SerializeField]
	private GameObject menu;
	
	public void Restart()
	{
		controlePersonnage.gameOver = false;
		spawner.gameOver = false;
		menu.SetActive(false);
		controlePersonnage.animator.SetFloat("Speed_f", 1f);
		controlePersonnage.animator.SetBool("Death_b", false);
	}
	
	public void Quit()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}
}