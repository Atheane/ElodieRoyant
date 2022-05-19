using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
    public List<TabItem> _tabItems;
    public Sprite _tableIdle;
    public Sprite _tableHover;
    public Sprite _tableActive;
    public TabItem _selectedItem;
    public List<GameObject> _pages;

    public void Subscribe(TabItem item)
    {
        if(_tabItems == null)
        {
            _tabItems = new List<TabItem>();
        }
        _tabItems.Add(item);
    }

    public void OnTabEnter(TabItem item)
    {
        ResetTabs();
        if(_selectedItem == null || item != _selectedItem)
        {
            item._background.sprite = _tableHover;
        }
    }

    public void OnTabSelected(TabItem item)
    {
        _selectedItem = item;
        ResetTabs();
        item._background.sprite = _tableActive;
        int index = item.transform.GetSiblingIndex();
        for(int i = 0; i < _pages.Count; i++)
        {
            if (i == index)
            {
                _pages[i].SetActive(true);
            } else
            {
                _pages[i].SetActive(false);
            }
        }

    }

    public void OnTabExit(TabItem item)
    {
        ResetTabs();
    }

    public void ResetTabs()
    {
        foreach(TabItem item in _tabItems)
        {
            if (_selectedItem != null && item == _selectedItem) { continue; }
            item._background.sprite = _tableIdle;
        }
    }
}
