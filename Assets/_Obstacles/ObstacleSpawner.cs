using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    int i;
    public GameObject[] obstacles = new GameObject[4];

    private int itemIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        itemIndex = Random.Range(0, obstacles.Length);
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > i)
        {
            i += 1;
            GetObstacle();
            SpawnObstacle();
        }
    }

    public GameObject GetObstacle()
    {
        int index = Random.Range(0, obstacles.Length); //selects one of the items from array
        return obstacles[index];
    }

    public GameObject SpawnObstacle()
    {
        GameObject obstacle = GetObstacle();
        GameObject o = Instantiate(obstacle, transform.position, transform.rotation) as GameObject;
        return o;
    }
}
