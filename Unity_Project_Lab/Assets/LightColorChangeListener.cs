using UnityEngine;
using System.Collections;
using Hover.Cast.Items;
using Hover.Common.Items;
using Hover.Common.Items.Types;

public class LightColorChangeListener : HovercastItemListener<ISliderItem>
{
    public Light mLight;
	// Use this for initialization
	void Start () {
        Setup();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected override void Setup()
    {
        Item.OnValueChanged += HandleValueChanged;
       
    }

    protected override void BroadcastInitialValue()
    {
        HandleValueChanged(Item);
    }

    private void HandleValueChanged(ISelectableItem pItem)
    {
        float delta = Item.RangeMax - Item.RangeMin;
        if (Item.RangeValue < Item.RangeMin +  delta / 3)
        {
            mLight.color = Color.red;
            return;
        }
        if (Item.RangeValue < Item.RangeMin + 2 * delta / 3)
        {
            mLight.color = Color.green;
            return;
        }
        if (Item.RangeValue < Item.RangeMin + 3 * delta / 3)
        {
            mLight.color = Color.blue;
            return;
        }

    }

}
