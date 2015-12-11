using UnityEngine;
using System.Collections;

public class IndoorProjectorController : MonoBehaviour {

    // Use this for initialization

    public GameObject projector;

    private Material mMaterial;
    private  MovieTexture mMovieTex;
    private Vector3 upDownDirection = new Vector3(0.0f,4.034f / 20.0f, 0.0f);

	void Start () {
        //Mesh mesh = projector.GetComponent<MeshFilter>().mesh;
        //Debug.Log(mesh.name + " has " + mesh.subMeshCount + " submeshes!");
        mMovieTex = (MovieTexture)projector.GetComponent<MeshRenderer>().material.mainTexture;
        mMovieTex.loop = false;
        
        //mMovieTex.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.PageDown))
        {
            makeTheProjectorDown();
        }

        if (Input.GetKey(KeyCode.PageUp))
        {
            makeTheProjectorUp();
        }

        // play movie
        if (Input.GetKey(KeyCode.P))
        {
            playMovie();
        }

        // pause movie
        if (Input.GetKey(KeyCode.O))
        {
            pauseMovie();
        }

        // stop movie
        if (Input.GetKey(KeyCode.I))
        {
            stopMovie();
        }

        //Debug.Log(mMovieTex.duration);

    }

    public void makeTheProjectorDown()
    {
        CancelInvoke();
        InvokeRepeating("doProjectorDown", 0.5f, 0.1F);
    }

    public void makeTheProjectorUp()
    {
        CancelInvoke();
        InvokeRepeating("doProjectorUp", 0.5f, 0.1F);
    }

    // make the project down
    void doProjectorDown()
    {
        if (projector.transform.position.y <= 14.3f)
        {
            projector.transform.position = new Vector3(projector.transform.position.x, 14.3f, projector.transform.position.z);
            CancelInvoke();
        }
        else
        {
            projector.transform.position = projector.transform.position - upDownDirection;
        }
    }

    void doProjectorUp()
    {
        if (projector.transform.position.y >= 34.47f)
        {
            projector.transform.position = new Vector3(projector.transform.position.x, 34.47f, projector.transform.position.z);
            CancelInvoke();
        }
        else
        {
            projector.transform.position = projector.transform.position + upDownDirection;
        }
    }

    public void playMovie()
    {
        //if (!mMovieTex.isPlaying)
        mMovieTex.Play();
        //if (mMovieTex.loop = )
    }

    public void pauseMovie()
    {
        if (mMovieTex.isPlaying)
            mMovieTex.Pause();
    }

    public void stopMovie()
    {
        mMovieTex.Stop();
    }



}
