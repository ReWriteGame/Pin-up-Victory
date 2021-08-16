using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceController : MonoBehaviour
{
    [SerializeField] private PriceData data;
    [SerializeField] private Text myPrice;


    [SerializeField] private Text RUB;
    [SerializeField] private Text PLN;
    [SerializeField] private Text BYN;    
    [SerializeField] private Text YPN;

    [SerializeField] private Text showRUB;
    [SerializeField] private Text showPLN;
    [SerializeField] private Text showBYN;
    [SerializeField] private Text showYPN;

    public void applyPrice()
    {
        data.RUB = float.Parse(RUB.text);
        data.PLN = float.Parse(PLN.text);
        data.BYN = float.Parse(BYN.text);
        data.YPN = float.Parse(YPN.text);
    }
    public void showPrice()
    {
        showRUB.text = $"{data.RUB}";
        showPLN.text = $"{data.PLN}";
        showBYN.text = $"{data.BYN}";
        showYPN.text = $"{data.YPN}";
    }


    public void calculateMoney()
    {
        RUB.text = $"{data.RUB * float.Parse(myPrice.text)}";
        PLN.text = $"{data.PLN * float.Parse(myPrice.text)}";
        BYN.text = $"{data.BYN * float.Parse(myPrice.text)}";
        YPN.text = $"{data.YPN * float.Parse(myPrice.text)}";
    }
}
