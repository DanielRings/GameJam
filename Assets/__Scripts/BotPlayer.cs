using UnityEngine;

public class BotPlayer : Player {

    public static BotPlayer S;

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

        numKeys = 0;
    }

    public void PickUpKey()
    {
        numKeys++;
    }

    public bool HasKeys(int num)
    {
        return numKeys >= num;
    }

    public void UseKeys(int num)
    {
        numKeys -= num;
    }
}
