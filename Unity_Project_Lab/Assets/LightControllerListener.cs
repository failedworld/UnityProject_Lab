using UnityEngine;
using System.Collections;
using Hover.Cast.Items;
using Hover.Common.Items;
using Hover.Common.Items.Types;

public class LightControllerListener : HovercastItemListener<ISelectorItem>
{
    public GameObject controller;

    private IndoorLightController mLightCtrl;
    bool isTurn = true;
    // Use this for initialization
    void Start () {
        Setup();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected override void Setup()
    {
        Item.OnSelected += onSelected;
        mLightCtrl = controller.GetComponent<IndoorLightController>();
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
            mLightCtrl.mLight.enabled = false;
            Item.Label = "Light Turn ON";
            isTurn = false;
        }
        else
        {
            mLightCtrl.mLight.enabled = true;
            Item.Label = "Light Turn OFF";
            isTurn = true;
        }
        
    }
}
