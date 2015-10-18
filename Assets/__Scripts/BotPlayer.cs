using UnityEngine;

public class BotPlayer : Player {

    public static BotPlayer S;

    public int lives;

    public bool _____________________;

    private int numKeys;

    // Use this for initialization
    protected override void Start()
    {
        base.Start();

        S = this;
        upKey = KeyCode.W;
        downKey = KeyCode.S;
        leftKey = KeyCode.A;
        rightKey = KeyCode.D;

        lives = 3;

        numKeys = 0;
		KeyGUI.S.GetComponent<GUIText> ().text = "x " + numKeys.ToString ();
    }

    public void PickUpKey()
    {
        numKeys++;
		KeyGUI.S.GetComponent<GUIText> ().text = "x " + numKeys.ToString ();
    }

    public bool HasKeys(int num)
    {
        return numKeys >= num;
    }

    public void UseKeys(int num)
    {
        numKeys -= num;
		KeyGUI.S.GetComponent<GUIText> ().text = "x " + numKeys.ToString ();
    }

    public void loseLife()
    {
        lives--;
        if(lives <= 0)
        {
            lives = 3;
            Application.LoadLevel("_Scene_1");
        }
    }

    public void gainLife()
    {
        lives++;
    }
}
