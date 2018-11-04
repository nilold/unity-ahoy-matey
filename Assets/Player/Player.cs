using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

    [SerializeField] float moveSpeed = 5f;
    private Vector3 inputValue;
    //private Camera myCamera;

	void Start () {
        //myCamera = GetComponentInChildren<Camera>();
	}
	
	void Update () {
        if (!isLocalPlayer)
            return;

        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        inputValue.y = 0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;

        transform.Translate(inputValue);
	}

    public override void OnStartLocalPlayer()
    {
        GetComponentInChildren<Camera>().enabled = true;
    }
}
