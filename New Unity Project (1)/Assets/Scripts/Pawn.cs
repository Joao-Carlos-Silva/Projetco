using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Pawn
{
    [SerializeField] private Place currentPlace;

    public Place CurrentPlace
    {
        get => currentPlace;
        set => currentPlace = value;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
