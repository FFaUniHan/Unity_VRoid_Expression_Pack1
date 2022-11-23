using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class UIButtonArrange : MonoBehaviour
{
    [SerializeField] private string title;
    [SerializeField] private Grid grid;
    [SerializeField] private List<GameObject> buttons;

    private void OnValidate()
    {
        Sort();
        ArrangeGrid();
    }

    public void Sort()
    {
        //Remove first. We want Default always at the first
        GameObject first = buttons[0];
        buttons.RemoveAt(0);

        //Copy List to Array
        GameObject[] buttonArray = buttons.ToArray();

        //Sort
        Array.Sort(buttonArray, (a, b) => a.name.CompareTo(b.name));

        //Readd to List
        buttons.Clear();
        buttons.Add(first);
        buttons.AddRange(buttonArray);
    }

    public void ArrangeGrid()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            Vector2 gridPosition = MapToGrid(i);
            ArrangeButtonPosition(buttons[i], gridPosition);
        }
    }

    /// <summary>
    /// Find this GridPosition of this index
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public Vector2 MapToGrid(int index)
    {
        //int y = (int)(index / 3);
        //int x = index % 3;
        int y = (int)(index / grid.width);
        int x = index % grid.width;
        return new Vector2(x, y);
    }

    /// <summary>
    /// Using GridPosition, calculate this button position on the grid
    /// </summary>
    /// <param name="button"></param>
    /// <param name="gridPosition"></param>
    public void ArrangeButtonPosition(GameObject button, Vector2 gridPosition)
    {
        Vector3 position = Vector3.zero;
        position.x = grid.xOrigin + (grid.xInterval * gridPosition.x);
        position.y = grid.yOrigin + (grid.yInterval * gridPosition.y);

        button.transform.localPosition = position;
    }

    [System.Serializable]
    public struct Grid
    {
        public int width;
        public float xOrigin;
        public float yOrigin;
        public float xInterval;
        public float yInterval;
    }
}
