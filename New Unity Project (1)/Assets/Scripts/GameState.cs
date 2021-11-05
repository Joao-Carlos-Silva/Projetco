using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameState
{
    [SerializeField] private Pawn[] pawns;
    // Start is called before the first frame update
    public Pawn[] Pawns => pawns;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
