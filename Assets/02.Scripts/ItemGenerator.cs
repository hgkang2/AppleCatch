using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float spawnTime = 1.0f;
    float delta = 0f;
    int ratio = 2;
    float speed = -0.03f;
    public void SetParameter(float span, float speed , int ratio)
    {
        spawnTime = span;
        this.speed = speed;
        this.ratio = ratio;
    }


    void Start()
    {
        
    }

    void Update()
    {
        delta += Time.deltaTime;
        if( spawnTime < delta )
        {
            delta = 0f;
            int dice = Random.Range(1, 11);
            GameObject item;
            if(dice <= ratio)
            {
                item = Instantiate(bombPrefab);
            }    
            else
            {
                item = Instantiate(applePrefab);
            }    
            int x = Random.Range(-1, 2);
            int z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 4, z);
            item.GetComponent<ItemController>().dropSpeed = this.speed;
        }
    }
}
