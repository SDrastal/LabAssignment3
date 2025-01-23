using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    // The variables that need to be around for all of the code
    public float storeDiscount = 0.4f;
    public int bookCost = 20;
    public int bookAmount = 15;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CalculateWholesale(bookCost, bookAmount));
    }

    float CalculateWholesale(float bookCost, int copyAmount)
    {
        //Gets the total cost for the amount of books purchased
        float totalCost = (bookCost * copyAmount) * (1 - storeDiscount);

        //Gets the total cost of shipping the quanity of books
        float shippingCost = 3 + (.75f * (copyAmount - 1));

        //Returns the total cost of the shipping and books
        return totalCost + shippingCost;
    }

}