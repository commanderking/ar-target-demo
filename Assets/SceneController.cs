using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {
    public enum SelectedObject
    {
        YOOP,
        FOOT,
        CAR
    }
    public int yoopCount;
    public Text counterText;
    public GameObject YoopCounterUI; 

    private bool shouldShowYoopCounter;
    private UnityEngine.GameObject[] GroundPlanes;
    public SelectedObject selectedObject;

    // Use this for initialization
    void Start () {
        YoopCounterUI.SetActive(false);
        yoopCount = 0;
        shouldShowYoopCounter = false;
        selectedObject = SelectedObject.YOOP;
    }

    private string getCounterText ()
    {
        return "Yoop Count: " + yoopCount.ToString();
    }

    private void setCounterText () 
    {
        counterText.text = getCounterText();
    }

    private UnityEngine.GameObject[] GetGroundPlanes ()
    {
        return GameObject.FindGameObjectsWithTag("GroundPlaneStage");
    }

    public void SelectObject(SelectedObject userSelectedObject)
    {
        selectedObject = userSelectedObject;
    }

    private void destroyCreatedGroundPlanes ()
    {
        GroundPlanes = GetGroundPlanes();
        /*
        foreach(GameObject groundPlane in GroundPlanes)
        {
            Destroy(groundPlane);
        }
        */
        for (int i = 1; i < GroundPlanes.Length; i++)
        {
            Destroy(GroundPlanes[i].gameObject);
        }
    }

    public void selectYoop()
    {
        SelectObject(SelectedObject.YOOP);
        destroyCreatedGroundPlanes();
    }

    public void selectCar()
    {
        SelectObject(SelectedObject.CAR);
        destroyCreatedGroundPlanes();
    }

    public void selectFoot()
    {
        SelectObject(SelectedObject.FOOT);
        destroyCreatedGroundPlanes();
    }

    public void undoYoop ()
    {
        GroundPlanes = GetGroundPlanes();
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
