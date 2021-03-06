﻿using UnityEngine;

public class TopPlayer : Player {

    public static TopPlayer S;

	public int ammo = 1;
	public GameObject bullet; 
	public GameObject targeting_sight ;
	public string button = "Fire1";
	public GameObject sight ;
	public Texture txtr;
	public Texture original;
    public float cooldown;

    public bool _______________;

	private int counter = 0;
    private float time;

	public void Awake()
	{
		S = this;
        time = Time.time;
	}

    // Use this for initialization
    protected override void Start () {
        base.Start();

		Seagull_gui.S.GetComponent<GUIText>().text = "x " + ammo.ToString() ;

        S = this;
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
		Seagull_gui.S.GetComponent<GUIText>().text = "x " + ammo.ToString() ;
		sight.transform.position = new Vector3 (transform.position.x, GameObject.Find("Bottom_Floor").transform.position.y + 0.6f , transform.position.z);

		if (counter > 0)
			counter--;
		else 
		{
			Seagull_gui.S.GetComponent<GUITexture>().texture = original;
		}

		if (Input.GetButtonDown(button) ) 
		{
			Action();
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag ("Ammo")) {
			//PLAY SOUND
			PickupSound.S.audio.Play();

			ammo+=3;
			col.gameObject.SetActive(false);
		}
	}

	protected override void Action()
	{
		if (ammo > 0) 
		{
            float t = Time.time;
            if (t - time < cooldown) return;
            time = t;
			GameObject Bomb = Instantiate (bullet) as GameObject;
			ammo--;
			Seagull_gui.S.GetComponent<GUITexture>().texture = txtr;
			counter = 10;

			Bomb.transform.position = new Vector3 (transform.position.x, transform.position.y - 3, transform.position.z);
            Bomb.GetComponent<Rigidbody>().velocity = new Vector3(0,-30,0);
		}
	}
}
