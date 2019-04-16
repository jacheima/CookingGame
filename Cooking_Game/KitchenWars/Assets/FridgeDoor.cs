using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FridgeDoor : MonoBehaviour {

    public Sprite[] doorStates;

    public Button openDoor;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
     
	}

    public void WalkInFridge()
    {
        if (openDoor.image.sprite == doorStates[0])
        {
            openDoor.image.sprite = doorStates[1];

           
        }

        Debug.Log("The player has opened the fridge door");

        if (openDoor.image.sprite == doorStates[1])
        {
            SceneManager.LoadScene("WalkInFridge");
        }

    }
}
