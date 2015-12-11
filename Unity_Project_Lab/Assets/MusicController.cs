using UnityEngine;
using System.Collections;
using Hover.Cast.Items;
using Hover.Common.Items;
using Hover.Common.Items.Types;

public class MusicController : MonoBehaviour {

    // Use this for initialization
    public GameObject mAudioPlayer;
    public AudioSource mMusicSource;

	void Start () {
        mMusicSource = mAudioPlayer.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.M))
            if (!mMusicSource.isPlaying)
                mMusicSource.Play();
        if (Input.GetKey(KeyCode.N))
            if (mMusicSource.isPlaying)
                mMusicSource.Stop();

    }
}
