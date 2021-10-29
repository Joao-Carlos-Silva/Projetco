using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameState currentGame;
    [SerializeField] private PawnInterface greenPawn;
    [SerializeField] private PawnInterface redPawn;
    private PawnInterface _selectedPawn;
    public static GameManager Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        greenPawn.GamePawn = currentGame.GreenPawn;
        redPawn.GamePawn = currentGame.RedPawn;

        redPawn.transform.position = redPawn.GamePawn.CurrentPlace.transform.position;
        greenPawn.transform.position = greenPawn.GamePawn.CurrentPlace.transform.position;
        if (Instance != null)
        {
            Debug.LogWarning("Multiple Game Managers");
        }

        Instance = this;
    }

    public void Click(PawnInterface pawn)
    {
        if (pawn == _selectedPawn)
        {
            _selectedPawn = null;
        }
        else
        {
            _selectedPawn = pawn;
        }
    }

    private void OnDrawGizmos()
    {
        if (_selectedPawn != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(_selectedPawn.transform.position, 1.0f);
        }
    }

    public void Click(Place place)
    {
        if (_selectedPawn == null)
        {
            return;
        }

        _selectedPawn.GamePawn.CurrentPlace = place;
        _selectedPawn.transform.position = place.transform.position;
        _selectedPawn = null;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
