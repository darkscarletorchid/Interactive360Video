using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	public string sceneName;

	void Start () {

	}

	public void LoadNextScene() {
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
		//Application.LoadLevel(sceneName);

	}
}
