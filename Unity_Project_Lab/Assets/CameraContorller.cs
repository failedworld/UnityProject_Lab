using UnityEngine;
using System.Collections;

public class CameraContorller : MonoBehaviour {

    // Use this for initialization
    public GameObject person;
    public Camera mCamera;

	void Start () {
        //mCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        //person.transform.position = new Vector3(mCamera.transform.position.x, person.transform.position.y, mCamera.transform.position.z);
	}
}
