using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]
public class RandomSound : MonoBehaviour {
	private int number = 0;
	public List <AudioClip> birds;
	private AudioSource source;
	//AudioSource[] birds = new AudioSource[3];

	// Use this for initialization
	void Start () {

		source = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
	


		if ((Input.GetButtonDown("Fire1") ) && TopPlayer.S.ammo > 0 ) {
			number = Random.Range (0, 3);
			source.clip = birds [number];

			if (!source.isPlaying) {
				source.Play ();
			}
		}

	}
}