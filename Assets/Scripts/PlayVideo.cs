using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour, TimedInputHandler {

	public GameObject gameObject;
	private VideoPlayer _videoPlayer;

	// Use this for initialization
	void Start () {
		_videoPlayer = gameObject.GetComponent(typeof(VideoPlayer)) as VideoPlayer;
	}
		
	public void PlayAlphaVideo()
	{
		Debug.Log (_videoPlayer.clip);
		_videoPlayer.Play();
	}

	public void  HandleTimedInput()
	{
		Debug.Log (_videoPlayer.clip + "timed");
		_videoPlayer.Play();
		var playBtn = GameObject.Find ("Play");
		playBtn.SetActive (false);

	}
}
