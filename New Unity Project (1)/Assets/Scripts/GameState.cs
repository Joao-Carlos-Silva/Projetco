using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameState
{
    [SerializeField] private Pawn redPawn;

    [SerializeField] private Pawn greenPawn;

    public Pawn RedPawn => redPawn;

    public Pawn GreenPawn => greenPawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
