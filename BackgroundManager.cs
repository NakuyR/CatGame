using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public Background[] background;
    public float scroll_speed;

    // Start is called before the first frame update
    void Start()
    {
        scroll_speed=5.0f;
        for (int i = 0; i<2;i++)
        {
            background[i].Init();
        }    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move_pos = Vector3.up*scroll_speed*Time.deltaTime;
        for (int i=0; i<2;++i)
        {
            background[i].Updated(move_pos);
        }
    }
}
