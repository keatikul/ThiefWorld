using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public Boat boat;

    [SerializeField] private GameObject FruitPrefab;
    [SerializeField] private GameObject PosPrefab;
    public Transform parentPlayer;
    public GameObject SpawnPos;
    public Vector2 UiPositon;
    // Start is called before the first frame update
    void Start()
    {
        ClonePrefab();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonePrefab()
    {

        GameObject prefab = Instantiate(FruitPrefab, transform.position , Quaternion.identity,parentPlayer);
        Debug.Log("Transform" + transform.position);
        Debug.Log("prefab" + prefab.transform.position);
    }
}
