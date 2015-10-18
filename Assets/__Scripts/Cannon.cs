using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

    private GameObject botPlayer;
    private Rigidbody botPlayerRigidBody;
    private BotPlayer botPlayerScript;
    private GameObject topPlayer;
    private Rigidbody topPlayerRigidBody;
    private TopPlayer topPlayerScript;

    private bool movingToCannon = false;
    private bool aimingCannon = false;
    private bool firingCannon = false;

    private float time = 0;
	
    void OnTriggerEnter(Collider col)
    {
        // Make sure it was actually the bottom player that collided
        if (col.gameObject != BotPlayer.S.gameObject) return;

        // Get useful player references
        botPlayer = BotPlayer.S.gameObject;
        botPlayerRigidBody = botPlayer.GetComponent<Rigidbody>();
        botPlayerScript = botPlayer.GetComponent<BotPlayer>();
        topPlayer = TopPlayer.S.gameObject;
        topPlayerRigidBody = topPlayer.GetComponent<Rigidbody>();
        topPlayerScript = topPlayer.GetComponent<TopPlayer>();

        // Disable BotPlayer
        botPlayerRigidBody.velocity = Vector3.zero;
        botPlayer.transform.rotation = Quaternion.LookRotation(botPlayer.transform.position) * Quaternion.Euler(0, 90, 0);
        botPlayerScript.anim.SetBool("Move", false);
        botPlayerScript.enabled = false;

        // Disable TopPlayer
        topPlayerRigidBody.velocity = Vector3.zero;
        topPlayer.transform.rotation = Quaternion.LookRotation(topPlayer.transform.position) * Quaternion.Euler(0, 90, 0);
        topPlayerScript.anim.SetBool("Move", false);
        topPlayerScript.enabled = false;

        // Begin moving to Cannon
        botPlayerScript.anim.SetBool("Move", true);
        botPlayerRigidBody.velocity = -(botPlayer.transform.position.normalized) * botPlayerScript.speed;
        movingToCannon = true;
    }

    void Update()
    {
        if (movingToCannon)
        {
            if (botPlayer.transform.position.z <= 1)
            {
                // Finish moving to cannon
                botPlayerScript.anim.SetBool("Move", false);
                botPlayerRigidBody.velocity = Vector3.zero;
                movingToCannon = false;

                // Enter the cannon
                botPlayer.transform.parent = gameObject.transform;
                botPlayer.transform.localPosition = new Vector3(0.25f, 1, 0);
                botPlayer.transform.localRotation = Quaternion.Euler(0, 0, 315f);
                
                aimingCannon = true;
            }
        }
        if (aimingCannon)
        {
            aimingCannon = false;
            firingCannon = true;
        }
        if (firingCannon)
        {
            if (time == 0) time = Time.time;
            //botPlayerRigidBody.constraints |= (RigidbodyConstraints.FreezePositionY);
            botPlayerRigidBody.velocity = new Vector3(0, 10, 10);
            if (Time.time - time > 3)
            {
                time = 0;
                firingCannon = false;
                Application.LoadLevel("_Scene_2");
            }
        }
    }
}
