using UnityEngine;
using System.Collections;

public class AoE : MonoBehaviour {

	private int counter = 15;
	
	// Update is called once per frame
	void Update () {
		if (counter < 1)
			{
			Destroy (this.gameObject);
			}
		else counter--;
	}


	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag ("Player")) {
			//Destroy (col.gameObject);
			col.gameObject.SetActive(false);
		}
		else 
		{
			counter = 15;
		}
	}
}
