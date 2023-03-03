using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "OBJScOb", menuName = "OBJScOb")]
public class OBJScOb : ScriptableObject
{
    [SerializeField] public List<GameObject> Objects = new List<GameObject>();
}
