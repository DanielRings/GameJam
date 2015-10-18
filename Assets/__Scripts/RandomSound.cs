using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]
public class RandomSound : MonoBehaviour {
	private int number = 0;
	public List <AudioClip> birds; 
	//AudioSource[] birds = new AudioSource[3];

	// Use this for initialization
	void Start () {
		number = Random.Range (0, 3);
		AudioSource source = GetComponent<AudioSource> ();
		source.clip = birds [number];
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (!source.isPlaying) {
				source.Play ();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}