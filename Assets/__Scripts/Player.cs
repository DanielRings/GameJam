using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public bool ____________________;

    private Vector3 velocity;

    private readonly Vector3 upDir = new Vector3(0, 0, 1);
    private readonly Vector3 downDir = new Vector3(0, 0, -1);
    private readonly Vector3 leftDir = new Vector3(-1, 0, 0);
    private readonly Vector3 rightDir = new Vector3(1, 0, 0);

	// Use this for initialization
	protected virtual void Start ()
    {
        speed = 5f;
	}

    // Update is called once per frame
    protected virtual void Update ()
    {
        Vector3 dir = Vector3.zero;
	    if (Input.GetKey(downKey))
        {
            dir += downDir;
        }
        if (Input.GetKey(upKey))
        {
            dir += upDir;
        }
        if (Input.GetKey(leftKey))
        {
            dir += leftDir;
        }
        if (Input.GetKey(rightKey))
        {
            dir += rightDir;
        }
        velocity = dir.normalized * speed;
	}

    protected virtual void FixedUpdate()
    {
        transform.position += velocity * Time.fixedDeltaTime;
    }
}
