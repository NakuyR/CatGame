using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Vector3 pos;
    public void Init()
    {
        pos = transform.position;
    }

    public void Updated(Vector3 move_pos){
        pos = pos+move_pos;
        if (pos.y > 30.0f)
        {
            pos = new Vector3(0.0f,-20.0f , 0.0f);
        }
        transform.position = pos;
    }
   
}
