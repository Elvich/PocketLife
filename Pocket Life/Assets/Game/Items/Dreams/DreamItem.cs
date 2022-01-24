using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DreamItem", menuName = "Dream/Items")]
public class DreamItem : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private int _price;
}
