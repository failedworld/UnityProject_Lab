using UnityEngine;
using System.Collections;

public class MoviePlayScript : MonoBehaviour {

    public Material mMaterial;
    public MovieTexture mMovieTex;
	// Use this for initialization
	void Start () {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Debug.Log(mesh.name + " has " + mesh.subMeshCount + " submeshes!");

        mMovieTex = (MovieTexture)GetComponent<MeshRenderer>().material.mainTexture;
        mMovieTex.Play();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
