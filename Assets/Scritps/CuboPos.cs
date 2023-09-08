using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboPos
{ 
    public Vector3 pos;
    public Quaternion rot;

    public CuboPos(Vector3 pos, Quaternion rot)
    {
        this.pos = pos;
        this.rot = rot;
    }
}
