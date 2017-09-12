using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour {

	public GameObject gObject;
	private VideoPlayer _videoPlayer;
	private MeshRenderer _meshRenderer;
	private Material _material;

	// Use this for initialization
	void Start () {
		_videoPlayer = gObject.GetComponent(typeof(VideoPlayer)) as VideoPlayer;
		//_meshRenderer = GameObject.Find ("MainSphere").GetComponent (typeof(MeshRenderer)) as MeshRenderer;
		//_material = new Material (Shader.Find ("GoogleVR/Unlit/Transparent Overlay"));
	}

	public void ChangeMaterial()
	{
		_meshRenderer.sharedMaterial = _material;

	}
	public void PlayAlphaVideo()
	{
		Debug.Log (_videoPlayer.clip);
		_videoPlayer.Play();
	}
}
