using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listado : MonoBehaviour
{
    List<CuboPos> list = new List<CuboPos>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            list.Add(new CuboPos(Vector3.zero, Quaternion.identity));

            for (int i = 0; i < list.Count; i++)
            {
                print(list[i]);

            }
        }   

    }
}
