using UnityEngine;

public class BotPlayer : Player {

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        upKey = KeyCode.W;
        downKey = KeyCode.S;
        leftKey = KeyCode.A;
        rightKey = KeyCode.D;
    }
}
