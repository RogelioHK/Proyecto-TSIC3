using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private List<Food> items = new List<Food>();
    [SerializeField] private GameObject buttonContainer;
    [SerializeField] private FoodButtonManager buttonManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.onFoodMenu += CreateButtons;
    }

    private void CreateButtons()
    {
        foreach (var item in items) {
            FoodButtonManager foodButton;
            foodButton = Instantiate(buttonManager, buttonContainer.transform);
            foodButton.FoodName = item.foodName;
            foodButton.FoodDescription = item.foodDescription;
            foodButton.FoodImage = item.foodImage;
            foodButton.FoodModel = item.foodModel;
            foodButton.FoodPrice = item.foodPrice;
            foodButton.name = item.name;
        }
        GameManager.Instance.onFoodMenu -= CreateButtons;
    }
}
