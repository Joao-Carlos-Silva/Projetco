using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.VFX;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameState currentGame;
    [SerializeField] private PawnInterface[] pawns;
    private RandomPlayer _randomPlayer = new RandomPlayer();
    private PawnInterface _selectedPawn;
    public static GameManager Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < pawns.Length; i++)
        {
            pawns[i].GamePawn = currentGame.Pawns[i];
            pawns[i].transform.position =
                currentGame.Pawns[i].CurrentPlace.transform.position;
        }
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

        if (CanMove(_selectedPawn.GamePawn, place))
        {
            Move(_selectedPawn.GamePawn, place);
            UpdatedPawnInterface(_selectedPawn);
            _selectedPawn = null;
        }
        
        
    }

    public bool CanMove(Pawn pawn, Place place)
    {
        return pawn.CurrentPlace.Connections.Contains(place) ||
               place.Connections.Contains(pawn.CurrentPlace);
    }

    public void Move(Pawn pawn, Place place)
    {
        pawn.CurrentPlace = place;
    }
// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            _randomPlayer.RandomMove(currentGame);
            UpdateInterfacePawns();
        }

    }
    public void UpdatedPawnInterface(PawnInterface pawn)
    {
        pawn.transform.position = pawn.GamePawn.CurrentPlace.transform.position;
    }
    private void UpdateInterfacePawns()
    {
        foreach (var p in pawns)
        {
            p.transform.position = p.GamePawn.CurrentPlace.transform.position;
        }
    }

    
    
    
}
