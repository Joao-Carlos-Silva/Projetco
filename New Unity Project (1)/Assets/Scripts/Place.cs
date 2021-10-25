using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
 
    [SerializeField] private Place[] connections;

    public Place[] Connections => connections;
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
}
