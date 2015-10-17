using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;

    public bool ____________________;

    private Vector3 velocity;

    private Direction direction;

    private readonly Vector3 upDir = new Vector3(0, 0, 1);
    private readonly Vector3 downDir = new Vector3(0, 0, -1);
    private readonly Vector3 leftDir = new Vector3(-1, 0, 0);
    private readonly Vector3 rightDir = new Vector3(1, 0, 0);

	// Use this for initialization
	void Start ()
    {
        // speed = 1f;
        direction = Direction.Up;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 dir = Vector3.zero;
	    if (Input.GetKey(KeyCode.DownArrow))
        {
            dir += downDir;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            dir += upDir;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir += leftDir;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dir += rightDir;
        }
        velocity = dir.normalized * speed;
	}

    void FixedUpdate()
    {
        transform.position += velocity * Time.fixedDeltaTime;
    }
}
