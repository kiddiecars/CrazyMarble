using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCameraController : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _zDistance;
    [SerializeField]
    private float _yDistance;

    // Update is called once per frame
    void Update()
    {
        Vector3 p = _target.position;
        p.z = p.z - _zDistance;
        p.y += _yDistance;
        transform.position = p;
    }
}