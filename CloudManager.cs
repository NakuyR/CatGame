using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManager : MonoBehaviour
{
    public GameObject cloudPrefab;
    private List<Cloud> cloudlist;
    private Dictionary<int, Vector3> map = new Dictionary<int, Vector3>();
    // Start is called before the first frame update
    void Awake()
    {
        MapInit();
        cloudlist = new List<Cloud>();
        foreach (Vector3 p in map.Values)
        {
            CreateMap(p);
        }
    }

    // Update is called once per frame
    void MapInit()
    {
        map.Add(0, new Vector3(1,16.6f,0));
        map.Add(1, new Vector3(-1.1f,15.5f,0));
        map.Add(2, new Vector3(-1.6f,13,0));
        map.Add(3, new Vector3(1.4f,13.2f,0));
        map.Add(4, new Vector3(1.1f,9,0));
        map.Add(5, new Vector3(-1.6f,7.7f,0));
        map.Add(6, new Vector3(1.6f,6.4f,0));
        map.Add(7, new Vector3(-0.1f, 4.2f,0));
        map.Add(8, new Vector3(1.4f,2.5f,0));
        map.Add(9, new Vector3(1.6f,-2.1f,0));
        map.Add(10, new Vector3(-1.6f,-2.8f,0));
        map.Add(11, new Vector3(-1.55f,-5.1f,0));
        map.Add(12, new Vector3(-0.2f,0.7f,0));
        map.Add(13, new Vector3(-1.6f,1.8f,0));
        map.Add(14, new Vector3(0,-5.1f,0));
        map.Add(15, new Vector3(1.55f,-5.1f,0));

    }

    void CreateMap(Vector3 pos)
    {
        GameObject clone = Instantiate(cloudPrefab) as GameObject;
        Cloud cloud = clone.GetComponent<Cloud>();
        cloud.Init(pos);
        cloudlist.Add(cloud);
    }
}
