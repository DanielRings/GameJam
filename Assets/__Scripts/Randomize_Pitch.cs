using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
 public class Randomize_Pitch : MonoBehaviour {
//	public float initDelay = 0.0;
//	public float between = 0.0;
	public float footAudioVol = 1.0f;
	public float volumeMod = 0.05f;
	public float pitchMod = 0.05f;
	public AudioClip audio;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 velocity = gameObject.GetComponentInParent<Rigidbody> ().velocity;
		if (velocity.x != 0 || velocity.z != 0) 
		{
			AudioSource audio = GetComponent<AudioSource>();
			audio.pitch = Random.Range(1.0f - pitchMod, 1.0f + pitchMod);
			audio.volume = Random.Range(footAudioVol - volumeMod, footAudioVol + volumeMod);
			if(!audio.isPlaying)
			{
				audio.Play();
				audio.Play(13025);
			}
		}
	}
}
