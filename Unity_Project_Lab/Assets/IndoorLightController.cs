using UnityEngine;
using System.Collections;

public class IndoorLightController : MonoBehaviour {

    // Use this for initialization
    public GameObject mLightObject;

    public Light mLight;

    void Start () {
        mLight = mLightObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F1))
            mLight.enabled = false;
        if (Input.GetKey(KeyCode.F2))
            mLight.enabled = true;
        //mLight.color
    }
}
