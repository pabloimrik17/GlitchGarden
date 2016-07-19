using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	private int currentLevel;
    public float autoLoadNextLevelAfter;

    void Start() {
        Invoke("LoadNextLevel",autoLoadNextLevelAfter);
    }

	public void LoadLevel (string levelName)
	{
		SceneManager.LoadScene(levelName);
	}

	public void QuitRequest ()
	{
		Application.Quit();
	}

	public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
