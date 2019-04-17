using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FridgeDoor : MonoBehaviour {

    public static string nameOfObject;
    public GameObject doorClosed;
    public GameObject doorOpen;

    private bool isDoorOpen = false;

    


	// Use this for initialization
	void Start () {
        doorOpen.SetActive(false);
        doorClosed.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
     
	}

    private void OnMouseDown()
    {
        doorClosed.SetActive(false);
        doorOpen.SetActive(true);
        isDoorOpen = true;

        if(isDoorOpen == true)
        {
            SceneManager.LoadScene("WalkInFridge");
        }

        
        
    }
}
