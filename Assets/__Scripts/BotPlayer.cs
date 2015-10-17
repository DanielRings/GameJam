using UnityEngine;

public class BotPlayer : Player {

    public bool _____________________;

    private int numKeys;

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
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
}
