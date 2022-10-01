using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitRandom : MonoBehaviour
{
    public Spawn04[] fruit;
    public Transform[] pos;
    public bool MyfunctionCalled = false;
    public static FruitRandom instantiateFruit;
    public int i = 0;
    //public int ii = 0;
    public string Fruitname;
    public int maxfruit;
    //public int amountThings = 2;
    //public GameObject friutt;
    public List<Spawn04> NewFruit;
    //public NewSpawn[] newFruitt;
    public int[] limit;
    public int apple;
    public int avocado;
    public int banana;
    public int cherries;
    public int lemon;
    public int peach;
    public int peanut;
    public int pear;
    public int strawberry;
    public int watermelon;
    public int pineapple;


    public void Start()
    {
        MakeSingleton();
        TestSpawn();
    }

    public void TestSpawn()
    {
        List<Transform> freeSpawnPoints = new List<Transform>(pos);
        //List<GameObject> NewFruit = new List<GameObject>();

        //StartGame
        //Test Spawn 1 object but every node : Done
        //Create List to get object
        //instatiate object in list to every node
        //check fruit how many fruit in node
        //use limit to fruit
        

            for (i = 0; i < freeSpawnPoints.Count; i++)
            {
                int index = Random.Range(0, NewFruit.Count);
                //Debug.Log("Fruit: " + NewFruit[index].name);
                if (NewFruit[index].maxProbability != 0)
                {     
                    Instantiate(NewFruit[index].spawnObject, freeSpawnPoints[i].position, freeSpawnPoints[i].rotation);
                    NewFruit[index].maxProbability--;
                    if (NewFruit[index].maxProbability == 0)
                    {
                        NewFruit.RemoveAt(index);
                        
                    }
                }
            {
                /*if (NewFruit[index].name == "avocado")
                { 
                    if (avocado != 0)
                    {
                        Instantiate(NewFruit[index], freeSpawnPoints[i].position, freeSpawnPoints[i].rotation);
                        avocado--;
                    }
                }
                if (NewFruit[index].name == "banana")
                {
                    if (banana != 0)
                    {
                        Instantiate(NewFruit[index], freeSpawnPoints[i].position, freeSpawnPoints[i].rotation);
                        banana--;
                    }
                }
                if (NewFruit[index].name == "cherries")
                {
                    if (cherries != 0)
                    {
                        Instantiate(NewFruit[index], freeSpawnPoints[i].position, freeSpawnPoints[i].rotation);
                        Debug.Log("cherries is full");
                        cherries--;
                    }
                }
                /*if (NewFruit[index].name == "lemon")
                {
                    lemon++;
                    if (lemon == 5)
                    {
                        NewFruit.RemoveAt(index);
                        Debug.Log("lemon is full");
                    }
                }
                if (NewFruit[index].name == "peach")
                {
                    peach++;
                    if (peach == 5)
                    {
                        NewFruit.RemoveAt(index);
                        Debug.Log("peach is full");
                    }
                }
                if (NewFruit[index].name == "peanut")
                {
                    peanut++;
                    Debug.Log("int peanut"+peanut);
                    if (peanut == 5)
                    {
                        NewFruit.RemoveAt(index);
                        Debug.Log("peanut is full");
                    }
                }
                if (NewFruit[index].name == "pear")
                {
                    pear++;
                    if (pear == 5)
                    {
                        NewFruit.RemoveAt(index);
                        Debug.Log("pear is full");
                    }
                }
                if (NewFruit[index].name == "strawberry")
                {
                    strawberry++;
                    if (strawberry == 5)
                    {
                        NewFruit.RemoveAt(index);
                        Debug.Log("strawberry is full");
                    }
                }
                if (NewFruit[index].name == "watermelon")
                {
                    watermelon++;
                    if (watermelon == 5)
                    {
                        NewFruit.RemoveAt(index);
                        Debug.Log("watermelon is full");
                    }
                }*/
            }
            }
        
        
    }

    public void SpawnObject()
    {
        /*List<Transform> freeSpawnPoints = new List<Transform>(pos);
        
            if (freeSpawnPoints.Count <= 0)
            {
                return;
            }
                
            int index = Random.Range(0, freeSpawnPoints.Count);
            Transform posi = freeSpawnPoints[index];

            freeSpawnPoints.RemoveAt(index);
            if (Spawn04.currentfruit < maxfruit)
            {
                i = Random.Range(0, 5);

                for (int j = 0; j < fruit.Length; j++)
                {
                    if (i >= fruit[j].minProbability && i <= fruit[j].maxProbability)
                    {
                        Instantiate(fruit[j].spawnObject, posi.position, posi.rotation);
                        Debug.Log("" + fruit[j].spawnObject.name);
                        Fruitname = fruit[j].spawnObject.name;
                        Spawn04.currentfruit++;
                    }
                }

            }*/


        //

        /*List<Transform> freeSpawnPoints = new List<Transform>(pos);
        if (Spawn04.currentfruit < maxfruit)
            {         
                i = Random.Range(0, 50);
                int randomspwan = Random.Range(0, freeSpawnPoints.Count);
                //int randomspwan = Random.Range(0, freeSpawnPoints.Count);
                //freeSpawnPoints.RemoveAt(randomspwan);

            for (int j = 0; j < fruit.Length; j++)
                {
                if (i >= fruit[j].minProbability && i <= fruit[j].maxProbability)
                    {
                        Instantiate(fruit[j].spawnObject, freeSpawnPoints[randomspwan].position, freeSpawnPoints[randomspwan].rotation);
                        //Debug.Log("" + fruit[j].spawnObject.name);
                        Fruitname = fruit[j].spawnObject.name;
                        Spawn04.currentfruit++;
                        //freeSpawnPoints.RemoveAt(randomspwan);
                    }
                }

            }*/
 
    }

    void MakeSingleton()
    {
        if (instantiateFruit == null)
        {
            instantiateFruit = this;
        }
    }


    private void Update()
    {

    }
   
}

[System.Serializable]
public class Spawn04
{
    public GameObject spawnObject;
    public int minProbability = 0;
    public int maxProbability = 0;
    public static int currentfruit = 0;
}

public class NewSpawn
{
    public GameObject _spwanObject;
    public int currentfruit = 0;
    public int maxfruit = 0;
}

public struct Fruit 
{

}