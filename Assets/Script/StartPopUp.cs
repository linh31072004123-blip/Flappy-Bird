using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPopUp : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btnClick;
     public void Init()
    {
        btnClick.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        gameObject.SetActive(false);
        GamePlayController.Instance.StartGame();

    }
}
