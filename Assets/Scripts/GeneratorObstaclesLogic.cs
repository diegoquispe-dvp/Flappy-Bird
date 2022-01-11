using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorObstaclesLogic : MonoBehaviour
{
    public float timeMax = 1;
    private float timeInitial = 0;
    public GameObject obstacle;
    public float height;
    void Start()
    {
        GameObject NewObstacle = Instantiate(obstacle);
        NewObstacle.transform.position = transform.position + new Vector3(0,0,0);
        Destroy(gameObject,10);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeInitial > timeMax)
        {
            GameObject NewObstacle = Instantiate(obstacle);
            NewObstacle.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
            Destroy(gameObject,10);
            timeInitial = 0;
        }
        else
        {
            timeInitial += Time.deltaTime;
        }
    }
}
