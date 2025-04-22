using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "Terrain Data", menuName = "etrrain Data")]
public class TerrainData : ScriptableObject
{
    public GameObject terrain;
    public int maxInSuccession; 
}
