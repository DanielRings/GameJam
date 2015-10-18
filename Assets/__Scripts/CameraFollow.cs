using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public bool cutscene = true;
    public GameObject target;
    public float smooth = 3.0f;
    public float xOffset;
    public float yOffset;
    public float zOffset;

    void LateUpdate()
    {
		if (cutscene == false) {
			Vector3 newPos = new Vector3 (target.transform.position.x + xOffset,
	                                              target.transform.position.y + yOffset,
	                                              target.transform.position.z + zOffset);
			this.transform.position = Vector3.Lerp (transform.position, newPos, smooth * Time.deltaTime);
		} 
		else if (Input.GetKeyDown (KeyCode.Return)) {
			//deal with Cutscene

			GameObject gui = GameObject.Find("TutGUI");
			gui.SetActive(false);
			cutscene = false;
		}



    }
}
