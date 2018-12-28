using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YoopCounter : MonoBehaviour {

    public int yoopCount;
    public Text counterText;
    public GameObject YoopCounterUI; 

    private bool shouldShowYoopCounter;
    private UnityEngine.GameObject[] GroundPlanes;
	// Use this for initialization
	void Start () {
        YoopCounterUI.SetActive(false);
        yoopCount = 0;
        shouldShowYoopCounter = false;
	}
	
    private string getCounterText ()
    {
        return "Yoop Count: " + yoopCount.ToString();
    }

    private void setCounterText () 
    {
        counterText.text = getCounterText();
    }

    public void undoYoop ()
    {
        GroundPlanes = GameObject.FindGameObjectsWithTag("GroundPlaneStage");
        Debug.Log(GroundPlanes.Length);
        if (yoopCount > 0)
        {
            Destroy(GroundPlanes[GroundPlanes.Length - 1]);
            yoopCount -= 1;
            setCounterText();
        }

    }

    private void initializeCounter ()
    {

        if (shouldShowYoopCounter == false)
        {
            shouldShowYoopCounter = true;
            YoopCounterUI.SetActive(true);
        }

    }

    public void onYoopAdded ()
    {
        initializeCounter();
        yoopCount += 1;
        setCounterText();
    }
}
