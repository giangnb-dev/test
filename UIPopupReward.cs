using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPopupReward : MonoBehaviour
{
    [SerializeField] private Text textNumberReward;

    public void SetNumberReward(int number)
    {
        textNumberReward.text = $"+{UtilityGame.ConvertKMT(number)}";
    }
}
