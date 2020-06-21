using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Manager<UIManager>
{
    [SerializeField] Text textPoints;
    // Start is called before the first frame update
    void Start()
    {
        textPoints.text = GameManager.Instance.Points.ToString();
    }

    public void AddPoints(int points)
    {
        GameManager.Instance.Points += points;
        textPoints.text = GameManager.Instance.Points.ToString();
    }


}
