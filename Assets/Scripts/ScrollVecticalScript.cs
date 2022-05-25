using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ScrollVecticalScript : MonoBehaviour, IPointerClickHandler, IScrollHandler
{
    private ScrollRect _scrollRect;
    private CellController[] _cells;

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
            int index = (int)Mathf.Round((1 - _scrollRect.verticalNormalizedPosition) * 44);

            foreach(CellController cell in _cells.Where(x => x._id <= index + 4))
            {
                cell.SetVisible();
            }
            foreach (CellController cell in _cells.Where(x => x._id > index + 4))
            {
                cell.SetInVisible();
            }
        }
    }
}
