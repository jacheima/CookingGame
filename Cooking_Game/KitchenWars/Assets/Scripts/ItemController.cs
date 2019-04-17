using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

    public static string nameOfIngredient;
    public GameObject ingredientNameText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        nameOfIngredient = gameObject.name;
        Destroy(gameObject);
        Destroy(ingredientNameText);
    }
}
