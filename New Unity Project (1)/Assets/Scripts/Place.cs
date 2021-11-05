using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Place : MonoBehaviour
{
 
    [SerializeField] private Place[] connections;

    public Place[] Connections => connections;


    private void OnMouseUp()
    {
        Debug.Log("Clicked A Place");
        GameManager.Instance.Click(this);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDrawGizmos()
    {
        foreach (var p in connections)
        {
            Gizmos.color = Color.white;
            Gizmos.DrawLine(transform.position, p.transform.position);
        }
    }
    
    private void Awake()
    {
        foreach (var p in connections)
        {
            List<Place> places = p.connections.ToList();
            if (!places.Contains(this))
            {
                places.Add(this);
                p.connections = places.ToArray();
            }
        }
    }
}
