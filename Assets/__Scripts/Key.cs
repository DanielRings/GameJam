using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == BotPlayer.S.gameObject)
        {
            BotPlayer.S.PickUpKey();
            Destroy(gameObject);
        }
    }
}
