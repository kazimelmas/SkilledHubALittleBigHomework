using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] numbers;
    public string[] names;
    float[] values = new float[5] { 3, 2, 5, 7, 0 };
    GameObject[] cubes;
    public List<GameObject> objList = new List<GameObject>();
}