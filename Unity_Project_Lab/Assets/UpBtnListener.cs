using UnityEngine;
using System.Collections;
using Hover.Cast.Items;
using Hover.Common.Items;
using Hover.Common.Items.Types;

public class UpBtnListener : HovercastItemListener<ISelectorItem>
{
    public HovercastItem upSelector;

    public GameObject controller;

    private IndoorProjectorController mProjectCtrl;
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
        mProjectCtrl.makeTheProjectorUp();
    }

}
