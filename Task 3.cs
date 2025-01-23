using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField]
    private int dollars = 125;
    // Start is called before the first frame update
    void Start()
    {
        

        int amtHundreds = CalculateAmountOfBills(100, ref dollars);
        int amtFiftys = CalculateAmountOfBills(50, ref dollars);
        int amtTwentys = CalculateAmountOfBills(20, ref dollars);
        int amtTens = CalculateAmountOfBills(10, ref dollars); 
        int amtFives = CalculateAmountOfBills(5, ref dollars);
        int amtOnes = CalculateAmountOfBills(1, ref dollars);

        Debug.Log($"Amount of hundreds: {amtHundreds}\nAmount of Fiftys: {amtFiftys}\nAmount of Twentys: {amtTwentys}\nAmount of Tens: {amtTens}\nAmount of fives: {amtFives}\nAmount of ones: {amtOnes}");

    }

    //must be called in descending order of size
    int CalculateAmountOfBills(int billSize, ref int dollarAmt)
    {
        int billAmount = dollarAmt / billSize;

        dollarAmt = dollarAmt % billSize;

        return billAmount;
    }

}
