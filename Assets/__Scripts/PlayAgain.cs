using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("_Scene_0");
        }
	}
}
