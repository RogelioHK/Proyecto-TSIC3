using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Food : ScriptableObject{
    public string foodName;
    public Texture foodImage;
    public string foodDescription;
    public string foodPrice;
    public GameObject foodModel;
}
