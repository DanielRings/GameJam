using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class PickupSound : MonoBehaviour {
	public static PickupSound S;

	public float footAudioVol = 1.0f;
	public AudioClip audio2;
	public AudioSource audio;
	

	void Awake()
	{
		S = this;
	}

	// Use this for initialization
	void Start () {
		
		audio = GetComponent<AudioSource>();
		audio.clip = audio2;
	}

}