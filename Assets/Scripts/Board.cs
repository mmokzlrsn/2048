using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private GameObject tilePrefab;

    [SerializeField] private TileGrid grid;
    [SerializeField] private List<Tile> tiles;
    [SerializeField] private int Size;
    [SerializeField] private TileState[] tileStates;

    private BoardMovementController boardMovementController;



    private void Awake()
    {
        grid = GetComponentInChildren<TileGrid>();
        boardMovementController = GetComponent<BoardMovementController>();
        tiles = new List<Tile>(Size);
    }

    private void Start()
    {
        CreateTile();
    }

    private void CreateTile()
    {
        //var tile = Instantiate(tilePrefab, grid.transform);
        Tile tile = Instantiate(tilePrefab, grid.transform).GetComponent<Tile>();
        tile.SetState(tileStates[0], 2);
        tile.Spawn(grid.GetRandomEmptyCell());
        tiles.Add(tile);
    }



}
