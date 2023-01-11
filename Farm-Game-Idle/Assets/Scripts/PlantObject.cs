using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plant", menuName = "Plant")] //project kýsmýnda create kýsmýnda plant diye doldurmaya hazýr bir veri kýsmý oluþuyor.
public class PlantObject : ScriptableObject
{
    public string plantName;
    public Sprite[] plantStages;
    public float timeBtwnStages;
}
