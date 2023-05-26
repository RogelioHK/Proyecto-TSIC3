using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject RestaurantMenu;
    [SerializeField] private GameObject FoodMenu;
    [SerializeField] private GameObject ARPositionMenu;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.onRestaurantMenu += ActivateRestMenu;
        GameManager.Instance.onFoodMenu += ActivateFoodMenu;
        GameManager.Instance.onARPosition += ActivateARPMenu;
    }

    private void ActivateRestMenu(){
        RestaurantMenu.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        RestaurantMenu.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        RestaurantMenu.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        RestaurantMenu.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        FoodMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        FoodMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        FoodMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }


    private void ActivateFoodMenu(){
        FoodMenu.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        FoodMenu.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        FoodMenu.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        RestaurantMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        RestaurantMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        RestaurantMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        RestaurantMenu.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateARPMenu(){
        ARPositionMenu.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        FoodMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        FoodMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        FoodMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }
}
