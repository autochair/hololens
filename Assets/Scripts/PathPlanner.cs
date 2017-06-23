using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPlanner : MonoBehaviour {

    public UDPCommunication comm;

    bool enabled;

    // Use this for initialization
    void Start () {

        enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Enable()
    {
        enabled = true;
    }

    private void Disable()
    {
        enabled = false;
    }
}
