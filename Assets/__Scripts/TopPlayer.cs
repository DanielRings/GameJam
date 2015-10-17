using UnityEngine;

public class TopPlayer : Player {

    // Use this for initialization
    protected override void Start () {
        base.Start();
        upKey = KeyCode.UpArrow;
        downKey = KeyCode.DownArrow;
        leftKey = KeyCode.LeftArrow;
        rightKey = KeyCode.RightArrow;
    }
}
