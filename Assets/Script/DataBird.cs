using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/DataBird", fileName = "DataBird.asset")]
public class DataBird : ScriptableObject
{
    public List<DataBirdProperty> dataBirdPropertyList;
}
public enum DataBirdType
{
    Norma,
    Rare,
    Epic,
    Legendary,
}
[System.Serializable]
public class DataBirdProperty
{
    public DataBirdType dataBirdType;
    public int id;
    public Sprite sprite;
    public int price;

}
