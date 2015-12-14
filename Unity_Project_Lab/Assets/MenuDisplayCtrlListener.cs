using UnityEngine;
using System.Collections;
using Leap;

public class MenuDisplayCtrlListener : MonoBehaviour {

    public HandController handCtrl;
    public GameObject hoverCast;
    public GameObject hoverBoard;
    public GameObject hoverBoardCursor;


    Frame currentFrame;
    Frame lastFrame = null;
    Frame thisFrame = null;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        currentFrame = handCtrl.GetFrame();
        HandList hlist = currentFrame.Hands;
        bool flag = false;
        foreach (Hand h in hlist)
        {
            if (h.IsLeft && hlist.Count == 1)
            {
                if (hoverCast.active)
                {
                    hoverBoard.SetActiveRecursively(true);
                    //hoverBoardCursor.SetActiveRecursively(true);
                    //hoverBoard.renderer.
                    hoverCast.SetActive(false);
                }
                flag = true;
                break;
            }
        }
        if (flag == false)
        {
            if (hoverBoard.active)
            {
                //hoverBoardCursor.SetActiveRecursively(false);
                hoverBoard.SetActiveRecursively(false);
                //hoverBoard.renderer.
                hoverCast.SetActive(true);
            }

        }
    }
}
