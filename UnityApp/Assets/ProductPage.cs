using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ProductPage : MonoBehaviour {
	Data Data;
	ProductManager PM;
	public Text productName;
	public Text productPrice;
	public Text Availability;
	public Dropdown color;
	public Dropdown size;
	bool inited;
	ProductInstance currProduct;

	List<string> shirtColors;
	List<string> shirtSizes;
	List<string> jeansColors;
	List<string> jeansSizes;
	List<string> jacketColors;
	List<string> jacketSizes;
	// Use this for initialization
	void Start () {
		shirtColors = new List<string> ();
		shirtSizes = new List<string> ();

		jeansColors = new List<string> ();
		jeansSizes = new List<string> ();

		jacketColors = new List<string> ();
		jacketSizes = new List<string> ();

		Data = GameObject.Find("Data").GetComponent<Data>();
		PM = transform.GetComponent<ProductManager> ();
		Debug.Log ("product page with id " + Data.currentScanID);

		shirtColors.Add ("Red");
		shirtColors.Add ("White");

		jeansColors.Add ("Blue");
		jeansColors.Add ("Grey");

		jacketColors.Add ("Black");
		jacketColors.Add ("Blue");

		shirtSizes.Add ("S");
		shirtSizes.Add ("M");
		shirtSizes.Add ("L");

		jeansSizes.Add ("S");
		jeansSizes.Add ("M");
		jeansSizes.Add ("L");

		jacketSizes.Add ("S");
		jacketSizes.Add ("M");
		jacketSizes.Add ("L");


	}
	
	// Update is called once per frame
	void Update () {
		if (PM.loaded && !inited) {
			inited = true;
			color.ClearOptions();
			size.ClearOptions ();



			if (Data.currentScanID == "101") {
				currProduct = PM.instances [0];
				color.AddOptions (shirtColors);
				size.AddOptions (shirtSizes);

			} else if (Data.currentScanID == "102") {
				currProduct = PM.instances [6];
				color.AddOptions (jeansColors);
				size.AddOptions (jeansSizes);
			}
			else if (Data.currentScanID == "103") {
				currProduct = PM.instances [12];
				color.AddOptions (jacketColors);
				size.AddOptions (jacketSizes);
			}


			setCurrentProduct ();	
		}
	}

	public void OnValueChanged(){
		if (Data.currentScanID == "101") {
			if (size.value == 0 && color.value == 0) {
				currProduct = PM.instances [0];
			} else if (size.value == 0 && color.value == 1) {
				currProduct = PM.instances [1];
			} else if (size.value == 1 && color.value == 0) {
				currProduct = PM.instances [2];
			}else if (size.value == 1 && color.value == 1) {
				currProduct = PM.instances [3];
			}else if (size.value == 2 && color.value == 0) {
				currProduct = PM.instances [4];
			}else if (size.value == 2 && color.value == 1) {
				currProduct = PM.instances [5];
			}



		}else if (Data.currentScanID == "102") {
			if (size.value == 0 && color.value == 0) {
				currProduct = PM.instances [6];
			} else if (size.value == 0 && color.value == 1) {
				currProduct = PM.instances [7];
			} else if (size.value == 1 && color.value == 0) {
				currProduct = PM.instances [8];
			}else if (size.value == 1 && color.value == 1) {
				currProduct = PM.instances [9];
			}else if (size.value == 2 && color.value == 0) {
				currProduct = PM.instances [10];
			}else if (size.value == 2 && color.value == 1) {
				currProduct = PM.instances [11];
			}




		}else if (Data.currentScanID == "103") {

			if (size.value == 0 && color.value == 0) {
				currProduct = PM.instances [12];
			} else if (size.value == 0 && color.value == 1) {
				currProduct = PM.instances [13];
			} else if (size.value == 1 && color.value == 0) {
				currProduct = PM.instances [14];
			}else if (size.value == 1 && color.value == 1) {
				currProduct = PM.instances [15];
			}else if (size.value == 2 && color.value == 0) {
				currProduct = PM.instances [16];
			}else if (size.value == 2 && color.value == 1) {
				currProduct = PM.instances [17];
			}
		}


		setCurrentProduct ();
	}
		

    public void onClickAddToCart()
    {
        Debug.Log("Added to cart");
    }

    public void onClickBack()
    {
        SceneManager.LoadScene("Boot");
    }

	public void setCurrentProduct(){
		productName.text = currProduct.getName();
		productPrice.text = "Price: " + currProduct.getPrice () + "€";
		Availability.text = "Availability: " + currProduct.getAvail ();
	}
}
