using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFireball : MonoBehaviour {
    public GameObject bowserTarget;
    public GameObject fireball; 
    private readonly int countOfFireballs;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Create() {
        if(bowserTarget != null)
        {
            fireball.transform.parent = bowserTarget.transform;
        }
    }
}
