using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    public bool _________________;
	public GameObject AoE; 



    void OnCollisionEnter(Collision col)
    {
		GameObject boom = Instantiate (AoE) as GameObject;
		boom.transform.position = this.transform.position;
		//boom.Explode ();
		Destroy(gameObject);
    }
}
