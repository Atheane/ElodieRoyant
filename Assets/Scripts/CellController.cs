using System.Text.RegularExpressions;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CellController : MonoBehaviour
{
    public Sprite _visible;
    public Sprite _invisible;
    public int _id = 0;

    private void Start()
    {
        try
        {
            _id = int.Parse(Regex.Match(gameObject.name, @"\d+").Value);
        } catch(Exception e)
        {
            Debug.Log(e);
        }
    }

    public void SetVisible()
    {
        GetComponent<Image>().sprite = _visible;
    }
    public void SetInVisible()
    {
        GetComponent<Image>().sprite = _invisible;
    }
}
