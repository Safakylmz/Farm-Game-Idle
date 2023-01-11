using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{
    bool isPlanted = false;
    SpriteRenderer plant;
    BoxCollider2D plantCollider;

    int plantStage = 0;
    float timer;

    public PlantObject selectedPlant;

    private void Start()
    {
        plant = transform.GetChild(0).GetComponent<SpriteRenderer>();
        plantCollider = transform.GetChild(0).GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (isPlanted)
        {
            timer -= Time.deltaTime;

            if (timer < 0 && plantStage < selectedPlant.plantStages.Length-1)    
            {
                timer = selectedPlant.timeBtwnStages;
                plantStage++;
                UpdatePlant();
            }

        }
    }
    private void OnMouseDown()
    {

        if (isPlanted)
        {
            if(plantStage == selectedPlant.plantStages.Length - 1)
            {
                Harvest();
            }

        }
        else
        {
            Plant();
        }
    }

    void Harvest()
    {
        isPlanted = false;
        plant.gameObject.SetActive(false);
    }

    void Plant()
    {
        isPlanted = true;
        plantStage = 0;
        UpdatePlant();
        timer = selectedPlant.timeBtwnStages;
        plant.gameObject.SetActive(true);
    }

    void UpdatePlant()
    {
        plant.sprite = selectedPlant.plantStages[plantStage];
        plantCollider.size = plant.sprite.bounds.size;
        plantCollider.offset = new Vector2(0, plant.bounds.size.y / 2); //bitkilerin sprite pivot noktas� bottom oldu�u i�in d�zeltme yapt�k.
    }
}