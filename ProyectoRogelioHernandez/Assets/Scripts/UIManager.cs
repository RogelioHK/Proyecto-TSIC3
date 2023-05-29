using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour{
    [SerializeField] private GameObject RestaurantMenu;
    [SerializeField] private GameObject FoodMenu;
    [SerializeField] private GameObject ARPositionMenu;

    private Vector3 rmStartPosition0;
    private Vector3 rmStartPosition1;
    private Vector3 rmStartPosition2;
    private Vector3 rmStartPosition3;

    private Vector3 fmStartPosition0;

    private Vector3 rmEndPosition0;
    private Vector3 rmEndPosition1;
    private Vector3 rmEndPosition2;
    private Vector3 rmEndPosition3;

    private Vector3 fmEndPosition0;

    // Start is called before the first frame update
    void Start(){
        GameManager.Instance.onRestaurantMenu += ActivateRestMenu;
        GameManager.Instance.onFoodMenu += ActivateFoodMenu;
        GameManager.Instance.onARPosition += ActivateARPMenu;
        rmStartPosition0 = RestaurantMenu.transform.GetChild(0).transform.position;
        rmStartPosition1 = RestaurantMenu.transform.GetChild(1).transform.position;
        rmStartPosition2 = RestaurantMenu.transform.GetChild(2).transform.position;
        rmStartPosition3 = RestaurantMenu.transform.GetChild(3).transform.position;

        fmStartPosition0 = FoodMenu.transform.GetChild(0).transform.position;

        rmEndPosition0 = new Vector3(rmStartPosition0.x + 1280f, rmStartPosition0.y, rmStartPosition0.z);
        rmEndPosition1 = new Vector3(rmStartPosition1.x + 1280f, rmStartPosition1.y, rmStartPosition1.z);
        rmEndPosition2 = new Vector3(rmStartPosition2.x + 1280f, rmStartPosition2.y, rmStartPosition2.z);
        rmEndPosition3 = new Vector3(rmStartPosition3.x + 1200f, rmStartPosition3.y, rmStartPosition3.z);

        fmEndPosition0 = new Vector3(fmStartPosition0.x, fmStartPosition0.y - 2260f, fmStartPosition0.z);

        ActivateRestMenu();
    }

    private void ActivateRestMenu(){
        RestaurantMenu.transform.GetChild(0).transform.DOMove(rmEndPosition0, 0.5f);
        RestaurantMenu.transform.GetChild(1).transform.DOMove(rmEndPosition1, 0.5f);
        RestaurantMenu.transform.GetChild(2).transform.DOMove(rmEndPosition2, 0.5f);
        RestaurantMenu.transform.GetChild(3).transform.DOMove(rmEndPosition3, 0.5f);
        
        FoodMenu.transform.GetChild(0).transform.DOMove(fmStartPosition0, 0.1f);
        FoodMenu.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.1f);
        FoodMenu.transform.GetChild(2).transform.DOScale(new Vector3(0,0,0), 0.1f);
        FoodMenu.transform.GetChild(3).transform.DOScale(new Vector3(0,0,0), 0.1f);

        ARPositionMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ARPositionMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

    private void ActivateFoodMenu(){
        FoodMenu.transform.GetChild(0).transform.DOMove(fmEndPosition0, 0.5f);
        FoodMenu.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 0), 0.5f);
        FoodMenu.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 0), 0.5f);
        FoodMenu.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 0), 0.5f);


        RestaurantMenu.transform.GetChild(0).transform.DOMove(rmStartPosition0, 0.5f);
        RestaurantMenu.transform.GetChild(1).transform.DOMove(rmStartPosition1, 0.5f);
        RestaurantMenu.transform.GetChild(2).transform.DOMove(rmStartPosition2, 0.5f);
        RestaurantMenu.transform.GetChild(3).transform.DOMove(rmStartPosition3, 0.5f);

        ARPositionMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ARPositionMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

    private void ActivateARPMenu(){
        ARPositionMenu.transform.GetChild(0).transform.DOScale(new Vector3(1,1,0), 0.5f);
        ARPositionMenu.transform.GetChild(1).transform.DOScale(new Vector3(1,1,0), 0.5f);

        FoodMenu.transform.GetChild(0).transform.DOMove(fmStartPosition0, 0.5f);
        FoodMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FoodMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FoodMenu.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
}
