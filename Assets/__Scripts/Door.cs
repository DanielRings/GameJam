using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public int keysRequired;

    public bool _______________;

    private bool playerInRange = false;
	
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == BotPlayer.S.gameObject)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject == BotPlayer.S.gameObject)
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.Tab))
        {
            if (BotPlayer.S.HasKeys(keysRequired))
            {
                BotPlayer.S.UseKeys(keysRequired);
                Destroy(gameObject);
            }
        }
    }
}
