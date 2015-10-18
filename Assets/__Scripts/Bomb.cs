using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	public GameObject AoE;

    public bool _________________;

    void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.tag);
        if (col.gameObject.tag == "AoE" || col.gameObject.tag == "Bomb") return;
		Destroy(gameObject);
		GameObject boom = Instantiate (AoE) as GameObject;
		boom.transform.position = this.transform.position;
		//boom.Explode ();
    }
}
