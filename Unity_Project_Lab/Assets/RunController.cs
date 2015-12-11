using UnityEngine;
using System.Collections;
using Hover.Cast.Items;
using Hover.Common.Items;
using Hover.Common.Items.Types;
using UnityStandardAssets.Characters.ThirdPerson;

public class RunController : HovercastItemListener<IStickyItem>
{
    public GameObject controller;

    private  ThirdPersonUserControl runnerCtrl;
    bool isRun = false;
    // Use this for initialization
    void Start () {
        Setup();
    }
	
	// Update is called once per frame
	void Update () {
        if (isRun)
        {
            float h = 0.0f;
            float v = 0.2f;
            runnerCtrl.runForward(h, v);
        }
    }

    protected override void Setup()
    {
        Item.OnSelected += onSelected;
        Item.OnDeselected += onDisSelected;
        runnerCtrl = controller.GetComponent<ThirdPersonUserControl>();
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
        //if (Item.IsStickySelected)
        isRun = true;

    }
    private void onDisSelected(ISelectableItem pItem)
    {
        //if (!pItem.IsStickySelected)
        //{
        //    return;
        //}

        //ISelectorItem upBtn = (ISelectorItem)upSelector.GetItem();
        //InvokeRepeating("doProjectorDown", 0.5f, 0.1F);
        //if (Item.IsStickySelected)
        isRun = false;

    }
}
