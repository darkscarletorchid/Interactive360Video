using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour, TimedInputHandler {

	public string sceneName;

	void Start () {

	}

	public void HandleTimedInput() {
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
		//Application.LoadLevel(sceneName);

	}
}
