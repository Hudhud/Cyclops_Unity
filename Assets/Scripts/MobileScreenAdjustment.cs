using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.VR;

public class MobileScreenAdjustment : MonoBehaviour
{
    public Text WinText, LossText;
	// Use this for initialization
    void Start()
    {
        float width = Screen.width;
        float height = Screen.height;
        Vector3 winposition = WinText.transform.position;
        winposition.x = (width*1/5);
        winposition.y = (height*1/5);
        winposition.z = -185.9f;
        Vector3 lossposition = LossText.transform.position;
        lossposition.x = (width * 1/5);
        lossposition.y = (height * 1/5)-LossText.preferredHeight;
        lossposition.z = -185.9f;


        WinText.transform.position = winposition;
        LossText.transform.position = lossposition;
    }

}
