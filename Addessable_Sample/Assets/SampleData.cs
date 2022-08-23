using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newSampleData", menuName = "Sample Data")]
public class SampleData : ScriptableObject
{
    public GameObject player;
    public List<Sprite> Sprites;
}
