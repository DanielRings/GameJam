using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public int keysRequired;

    public bool _______________;

    private bool playerInRange = false;
	
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Left_S")
        {
            playerInRange = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Left_S")
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
