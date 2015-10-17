using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Left_S")
        {
            col.gameObject.GetComponent<BotPlayer>().PickUpKey();
            Destroy(this.gameObject);
        }
    }
}
