using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tile : MonoBehaviour
{
    public TileState State { get; private set; }
    public TileCell Cell { get; private set; } 
    public int Number { get; private set; }

    [SerializeField] private Image background;
    [SerializeField] private TextMeshProUGUI text;

    private void Awake()
    {
        //background = GetComponent<Image>();
        //text = GetComponent<TextMeshProUGUI>();
    }

    public void SetState(TileState state, int number)
    {
        State = state;
        Number = number;

        background.color = state.backgroundColor;
        text.color = state.textColor;
        text.text = number.ToString();
    }

    public void Spawn(TileCell cell)
    {
        if (Cell != null)
            Cell.Tile = null;

        Cell = cell;
        Cell.Tile = this;

        transform.position = cell.transform.position;
    }
}
