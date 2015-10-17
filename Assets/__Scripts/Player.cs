using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
	public string HorizontalAxis;
	public string VerticalAxis;

    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public bool ____________________;

    private Vector3 velocity;

    private readonly Vector3 upDir = new Vector3(1, 0, 0);
    private readonly Vector3 downDir = new Vector3(-1, 0, 0);
    private readonly Vector3 leftDir = new Vector3(0, 0, 1);
    private readonly Vector3 rightDir = new Vector3(0, 0, -1);

	// Use this for initialization
	protected virtual void Start ()
    {
        speed = 5f;
		velocity = new Vector3 (0,0,1);
	}

    // Update is called once per frame
    protected virtual void Update ()
    {

		GetComponent<Rigidbody> ().velocity = new Vector3(Input.GetAxis(HorizontalAxis),0f,Input.GetAxis(VerticalAxis)) * speed;
		if (GetComponent<Rigidbody> ().velocity != Vector3.zero) 
		{
			transform.rotation = Quaternion.LookRotation (GetComponent<Rigidbody> ().velocity)* Quaternion.Euler(0, -90, 0);
		}


	}

    protected virtual void FixedUpdate()
    {
       // transform.position += velocity * Time.fixedDeltaTime;
    }

	protected virtual void Action()
	{
	}

}
