using UnityEngine;

public class TopPlayer : Player {

	public int ammo = 5;
	public GameObject bullet; 
	public GameObject targeting_sight ;
	public KeyCode button = KeyCode.Space;
	public GameObject sight ;

    // Use this for initialization
    protected override void Start () {
        base.Start();
        upKey = KeyCode.UpArrow;
        downKey = KeyCode.DownArrow;
        leftKey = KeyCode.LeftArrow;
        rightKey = KeyCode.RightArrow;

		sight = Instantiate (targeting_sight) as GameObject;
		//targeting_sight =  Instantiate (targeting_sight) as GameObject;
    }

	protected override void Update()
	{
		base.Update ();

		sight.transform.position = new Vector3 (transform.position.x, GameObject.Find("Bottom_Floor").transform.position.y + 0.6f , transform.position.z);


		if (Input.GetKeyDown (button)) 
		{
			Action();
		}
	}

	protected override void Action()
	{
		if (ammo > 0) 
		{
			GameObject Bomb = Instantiate (bullet) as GameObject;
			Bomb.transform.position = new Vector3 (transform.position.x, transform.position.y - 3, transform.position.z);
		}
	}
}
