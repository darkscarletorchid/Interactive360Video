using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour, TimedInputHandler {

	public GameObject gObject;
	public Sprite mySprite;
	public GameObject playBtn;
	public GameObject switchScenes;

	private VideoPlayer _videoPlayer;
	private MeshRenderer _meshRenderer;

		
	void Start () {
		_videoPlayer = gObject.GetComponent(typeof(VideoPlayer)) as VideoPlayer;
		_videoPlayer.Prepare ();
		gObject.GetComponent<MeshRenderer>().enabled = false;

		playBtn = GameObject.Find ("Play");
	}

	private IEnumerator coroutine;

	public void  HandleTimedInput()
	{
		if (_videoPlayer.isPrepared) {
			gObject.GetComponent<MeshRenderer>().enabled = true;
			_videoPlayer.Play ();

			playBtn.SetActive (false);
			switchScenes.SetActive (false);

			//on video stop event delegate
			_videoPlayer.loopPointReached += EndReached;
		}
	}
		
	void EndReached(VideoPlayer vp)
	{
		playBtn.SetActive(true);
		switchScenes.SetActive (true);

		gObject.GetComponent<MeshRenderer>().enabled = false;

		var spr = playBtn.GetComponent<SpriteRenderer>();
		spr.sprite = mySprite;
	}
}
