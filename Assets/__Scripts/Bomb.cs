using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    public bool _________________;

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
