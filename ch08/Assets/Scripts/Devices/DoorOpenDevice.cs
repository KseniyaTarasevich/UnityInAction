using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] private Vector3 dPosition;

    private bool _open;

    void Operate()
    {
        if (_open)
        {
            Vector3 pos = transform.position - dPosition;
            transform.position = pos;
        }
        else
        {
            Vector3 pos = transform.position + dPosition;
            transform.position = dPosition;
        }
        _open = !_open;
    }
}
