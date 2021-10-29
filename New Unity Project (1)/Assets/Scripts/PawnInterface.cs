using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnInterface : MonoBehaviour
{
    private Pawn gamePawn;

    public Pawn GamePawn
    {
        get => gamePawn;
        set => gamePawn = value;        
    }

    private void OnMouseUp()
    {
        GameManager.Instance.Click(this);
        Debug.Log("Clicked on Pawn");
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
