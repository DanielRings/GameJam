using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class RandomSound : MonoBehaviour {
	private int number = 0;
	public AudioSource sound1;
	public AudioSource sound2;
	public AudioSource sound3;

	// Use this for initialization
	void Start () {
		number = Random.Range (1, 3);
		if (number == 1) {
			AudioSource sound1 = GetComponent<AudioSource> ();
			sound1.Play ();
		} else if (number == 2) {
			AudioSource sound2 = GetComponent<AudioSource> ();
			sound2.Play ();
		}
		if (number == 3) {
			AudioSource sound3 = GetComponent<AudioSource> ();
			sound3.Play ();
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
