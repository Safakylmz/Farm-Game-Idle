using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plant", menuName = "Plant")] //project k�sm�nda create k�sm�nda plant diye doldurmaya haz�r bir veri k�sm� olu�uyor.
public class PlantObject : ScriptableObject
{
    public string plantName;
    public Sprite[] plantStages;
    public float timeBtwnStages;
}
