using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action onRestaurantMenu;
    public event Action onFoodMenu;
    public event Action onARPosition;

    public static GameManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        RestaurantMenu();
    }

    public void RestaurantMenu() {
        onRestaurantMenu?.Invoke();
        Debug.Log("Restaurant Menu Active");
    }

    public void FoodMenu() {  
        onFoodMenu?.Invoke();
        Debug.Log("Food Menu Active");
    }

    public void ARPositionMenu()
    {
        onARPosition?.Invoke();
        Debug.Log("ARPosition active");
    }


}
