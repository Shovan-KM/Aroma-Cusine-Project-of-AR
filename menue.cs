using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menue : MonoBehaviour
{
    public GameObject[] food; // Array to hold food game objects
    public Text price;  // Reference to a Text component for displaying the price

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can go here, if needed
    }

    // Method for opening the pizza menu
    public void openPizza()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[0].SetActive(true);  // Activate the first food game object (pizza)
        price.text = "BDT: 390";
    }

    // Method for opening the hamburger menu
    public void openHamburger()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[1].SetActive(true);  // Activate the second food game object (hamburger)
        price.text = "BDT: 220";
    }

    // Method for opening the Big Mac menu
    public void openBigMac()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[2].SetActive(true);  // Activate the third food game object (Big Mac)
        price.text = "BDT: 290";
    }

    // Method for opening the Momo menu
    public void openMomo()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[3].SetActive(true);  // Activate the fourth food game object (Momo)
        price.text = "BDT: 150";
    }

    // Method for opening the Maggie menu
    public void openMaggie()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[4].SetActive(true);  // Activate the fifth food game object (Maggie)
        price.text = "BDT: 90";
    }

    // Update is called once per frame
    void Update()
    {

    }
}