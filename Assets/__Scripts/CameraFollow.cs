using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    public float smooth = 3.0f;
    public float xOffset;
    public float yOffset;
    public float zOffset;

    void LateUpdate()
    {
        Vector3 newPos = new Vector3(target.transform.position.x + xOffset,
                                              target.transform.position.y + yOffset,
                                              target.transform.position.z + zOffset);
        this.transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
    }
}
