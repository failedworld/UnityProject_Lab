using UnityEngine;
using System.Collections;
using Hover.Cast.Items;
using Hover.Common.Items;
using Hover.Common.Items.Types;

public class DownBtnListener : HovercastItemListener<ISelectorItem>
{

    public HovercastItem upSelector;

    public GameObject controller;

    private IndoorProjectorController mProjectCtrl;

    private bool ifTurned = false;
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
        mProjectCtrl = controller.GetComponent<IndoorProjectorController>();
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
        if (!ifTurned)
        {
            mProjectCtrl.makeTheProjectorDown();
            Item.Label = "Projector UP";
            ifTurned = true;
        }
        else {
            mProjectCtrl.makeTheProjectorUp();
            Item.Label = "Projector DOWN";
            ifTurned = false;
        }
            
    }
}
