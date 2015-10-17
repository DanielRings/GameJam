using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "")
        {
            col.gameObject.GetComponent<BotPlayer>().PickUpKey();
            Destroy(this.gameObject);
        }
    }
}
