using UnityEngine;
using System.Collections;
using Hover.Cast.Items;
using Hover.Common.Items;
using Hover.Common.Items.Types;

public class MusicControllerListener : HovercastItemListener<ISelectorItem>
{

    public GameObject controller;

    private MusicController mMusicCtrl;
    bool isTurn = true;
    // Use this for initialization
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Setup()
    {
        Item.OnSelected += onSelected;
        mMusicCtrl = controller.GetComponent<MusicController>();
    }

    protected override void BroadcastInitialValue()
    {

    }

    private void onSelected(ISelectableItem pItem)
    {
        //if (!pItem.IsStickySelected)
        //{
        //    return;
        //}

        //ISelectorItem upBtn = (ISelectorItem)upSelector.GetItem();
        //InvokeRepeating("doProjectorDown", 0.5f, 0.1F);
        if (isTurn)
        {
            if (!mMusicCtrl.mMusicSource.isPlaying)
                mMusicCtrl.mMusicSource.Play();
            Item.Label = "Music OFF";
            isTurn = false;
        }
        else
        {
            if (mMusicCtrl.mMusicSource.isPlaying)
                mMusicCtrl.mMusicSource.Stop();
            Item.Label = "Music ON";
            isTurn = true;
        }

    }
}
