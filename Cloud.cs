using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // Start is called before the first frame update
    public void Init(Vector3 pos)
    {
        SetPos(pos);
    }

    // Update is called once per frame
    public void SetPos(Vector3 pos)
    {
        transform.position = pos;
    }

    public Vector3 GetPos()
    {
        return transform.position;
    }
}
