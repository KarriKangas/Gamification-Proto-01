using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProductManager : MonoBehaviour {

	public ProductInstance[] instances;
	public bool loaded;
	// Use this for initialization
	void Start () {

		instances = new ProductInstance[18];
		constructProducts();
		loaded = true;
	}
		
	void constructProducts(){
		Product Tshirt = new Product ("100", "T-Shirt", 9.99f);
		Product Jeans = new Product ("101", "Jeans", 19.99f);
		Product Jacket = new Product ("102", "Jacket", 34.99f);
		//T-shirts
		ProductInstance TshirtRedM = new ProductInstance (Tshirt.getID (), Tshirt.getName (), Tshirt.getPrice (), 9, "M", "Red");
		instances [0] = TshirtRedM;
		ProductInstance TshirtRedS = new ProductInstance (Tshirt.getID (), Tshirt.getName (), Tshirt.getPrice (), 8, "S", "Red");
		instances [1] = TshirtRedS;
		ProductInstance TshirtRedL = new ProductInstance (Tshirt.getID (), Tshirt.getName (), Tshirt.getPrice (), 7, "L", "Red");
		instances [2] = TshirtRedL;

		ProductInstance TshirtWhiteM = new ProductInstance (Tshirt.getID (), Tshirt.getName (), Tshirt.getPrice (), 5, "M", "White");
		instances [3] = TshirtWhiteM;
		ProductInstance TshirtWhiteS = new ProductInstance (Tshirt.getID (), Tshirt.getName (), Tshirt.getPrice (), 6, "S", "White");
		instances [4] = TshirtWhiteS;
		ProductInstance TshirtWhiteL = new ProductInstance (Tshirt.getID (), Tshirt.getName (), Tshirt.getPrice (), 3, "L", "White");
		instances [5] = TshirtWhiteL;

		//Jeans
		ProductInstance JeansBlueM = new ProductInstance (Jeans.getID (), Jeans.getName (), Jeans.getPrice (), 1, "M", "Blue");
		instances [6] = JeansBlueM;
		ProductInstance JeansBlueS = new ProductInstance (Jeans.getID (), Jeans.getName (), Jeans.getPrice (), 4, "S", "Blue");
		instances [7] = JeansBlueS;
		ProductInstance JeansBlueL = new ProductInstance (Jeans.getID (), Jeans.getName (), Jeans.getPrice (), 3, "L", "Blue");
		instances [8] = JeansBlueL;

		ProductInstance JeansGreyM = new ProductInstance (Jeans.getID (), Jeans.getName (), Jeans.getPrice (), 3, "M", "Grey");
		instances [9] = JeansGreyM;
		ProductInstance JeansGreyS = new ProductInstance (Jeans.getID (), Jeans.getName (), Jeans.getPrice (), 1, "S", "Grey");
		instances [10] = JeansGreyS;
		ProductInstance JeansGreyL = new ProductInstance (Jeans.getID (), Jeans.getName (), Jeans.getPrice (), 2, "L", "Grey");
		instances [11] = JeansGreyL;


		//Jackets
		ProductInstance JacketBlackM = new ProductInstance (Jacket.getID (), Jacket.getName (), Jacket.getPrice (), 5, "M", "Black");
		instances [12] = JacketBlackM;
		ProductInstance JacketBlackS = new ProductInstance (Jacket.getID (), Jacket.getName (), Jacket.getPrice (), 3, "S", "Black");
		instances [13] = JacketBlackS;
		ProductInstance JacketBlackL = new ProductInstance (Jacket.getID (), Jacket.getName (), Jacket.getPrice (), 2, "L", "Black");
		instances [14] = JacketBlackL;

		ProductInstance JacketBlueM = new ProductInstance (Jacket.getID (), Jacket.getName (), Jacket.getPrice (), 1, "M", "Blue");
		instances [15] = JacketBlueM;
		ProductInstance JacketBlueS = new ProductInstance (Jacket.getID (), Jacket.getName (), Jacket.getPrice (), 0, "S", "Blue");
		instances [16] = JacketBlueS;
		ProductInstance JacketBlueL = new ProductInstance (Jacket.getID (), Jacket.getName (), Jacket.getPrice (), 1, "L", "Blue");
		instances [17] = JacketBlueL;
	}
}

public class Product {
	protected string id;
	protected string name;
	protected float price;



	public Product(string id, string name, float price){
		this.id = id;
		this.name = name;
		this.price = price;



	}

	public string getID(){
		return id;
	}

	public string getName(){
		return name;
	}

	public float getPrice(){
		return price;
	}


}

public class ProductInstance : Product{
	string size;
	string color;
	int availability;

	public ProductInstance(string id, string name, float price, int availability, string size, string color) : base(id, name, price){
		this.id = id;
		this.name = name;
		this.price = price;

		this.availability = availability;
		this.size = size;
		this.color = color;
	}

	public int getAvail(){
		return this.availability;
	}
}
