using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerUI : MonoBehaviour
{
    private Transform target;
    [SerializeField] private Transform ui;

    void Start()
    {
        target = transform;
    }

    // Update is called once per frame
    void Update()
    {
        ui.transform.position = Camera.main.WorldToScreenPoint(target.position);
    }

}
