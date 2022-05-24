using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class ScrollVecticalScript : MonoBehaviour, IPointerClickHandler, IScrollHandler
{
    private ScrollRect _scrollRect;
    public CellController[] _cells;

    // Start is called before the first frame update
    private void Start()
    {
        _scrollRect = GetComponent<ScrollRect>();
        _cells = FindObjectsOfType<CellController>();
    }

    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {
        SetCellVisible();
    }

    public void OnScroll(PointerEventData eventData)
    {
        SetCellVisible();
    }

    private void SetCellVisible()
    {
        if (_scrollRect != null)
        {
            int index = (int)Mathf.Round((1-_scrollRect.verticalNormalizedPosition) * 44);
            print(_scrollRect.verticalNormalizedPosition);
            print(index);
            print(_cells.Take(index));
            //todo put cells in correct order
            foreach(CellController cell in _cells.Take(index))
            {
                cell.SetVisible();
            }
        }
    }
}
