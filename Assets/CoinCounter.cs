using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{

    private int Count;
    public Text CoinText;
    public Text ScoreText;
    private int hiCoin;
    public Sprite sprite;

    [SerializeField] GameObject Ana_Karakter;
    [SerializeField] GameObject Ana_KarakterButton;
    [SerializeField] GameObject Ana_KarakterButtonR;
    [SerializeField] GameObject NewChar;
    [SerializeField] GameObject NewCharButton;
    [SerializeField] GameObject NewCharButtonR;
    [SerializeField] GameObject ThirdChar;
    [SerializeField] GameObject ThirdCharButton;
    [SerializeField] GameObject ThirdCharButtonR;
    [SerializeField] GameObject FourthChar;
    [SerializeField] GameObject FourthCharButton;
    [SerializeField] GameObject FourthCharButtonR;

    void Start()
    {
        if (PlayerPrefs.HasKey("TOTAL COIN"))
        {
            hiCoin = PlayerPrefs.GetInt("TOTAL COIN");
        }
        Count = 0;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
        {
            Count += 1;
            FindObjectOfType<AuidoManager>().Play("Coin");
            Destroy(collider.gameObject);
            CoinText.text = "Coin:" + Count;

        }
    }
    void Update()
    {
        if (Count > hiCoin)
        {
            hiCoin = Count;
            PlayerPrefs.SetInt("TOTAL COIN", hiCoin);
        }
        ScoreText.text = "Total Coin:" + hiCoin;
        if (10 <= hiCoin && hiCoin < 20)
        {
            Ana_Karakter.SetActive(false);
            NewChar.SetActive(true);
            Ana_KarakterButton.SetActive(false);
            Ana_KarakterButtonR.SetActive(false);
            NewCharButtonR.SetActive(true);
            NewCharButton.SetActive(true);



        }
        if (20 <= hiCoin && hiCoin < 30)
        {
            Ana_Karakter.SetActive(false);
            NewChar.SetActive(false);
            Ana_KarakterButton.SetActive(false);
            Ana_KarakterButtonR.SetActive(false);
            NewCharButtonR.SetActive(false);
            NewCharButton.SetActive(false);
            ThirdChar.SetActive(true);
            ThirdCharButton.SetActive(true);
            ThirdCharButtonR.SetActive(true);
        }
        if (30 <= hiCoin && hiCoin < 40)
        {
            Ana_Karakter.SetActive(false);
            NewChar.SetActive(false);
            ThirdChar.SetActive(false);
            Ana_KarakterButton.SetActive(false);
            Ana_KarakterButtonR.SetActive(false);
            NewCharButtonR.SetActive(false);
            NewCharButton.SetActive(false);
            ThirdCharButton.SetActive(false);
            ThirdCharButtonR.SetActive(false);
            FourthChar.SetActive(true);
            FourthCharButton.SetActive(true);
            FourthCharButtonR.SetActive(true);
        }
    }


}
