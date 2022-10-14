using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PointTracker : MonoBehaviour
{
    public Text pointsDisplay;
    public int points = 0;

    public void AddPoints(int pointsToAdd = 1)
    {
        points += pointsToAdd;
        pointsDisplay.text = "Points: " + points.ToString();
    }
}
