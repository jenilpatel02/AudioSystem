
using UnityEngine;
using UnityEngine.UI;

public class BasketUI : MonoBehaviour
{
    
    public string basketName;
    public int basketScore;
    public Text basketScoreText;
    public BasketType basketType;
    
    public enum BasketType
    {
        FruitBasket,
        AccessoryBasket,
        TrekkingBasket
    }
    
    void Start()
    {
        GetComponent<BoxCollider2D>();
        CountDown.instance.objremain = 15;
    }
    void update()
    {
        if (CountDown.instance.objremain == 0)
        {
            CountDown.instance.OverScreen.gameObject.SetActive(true);
            Debug.Log("gameover");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Objectbehaviour>() != null)
        {
            if ((int)basketType == (int)collision.GetComponent<Objectbehaviour>().objtype)
            {
                basketScore += collision.GetComponent<Objectbehaviour>().BasketScore;
                basketScoreText.text = basketScore.ToString();
                ScoreManager.Instance.AddMainScore(collision.GetComponent<Objectbehaviour>().scoring);               
            }
            else
            {
                ScoreManager.Instance.SubtractMainScore(collision.GetComponent<Objectbehaviour>().scoring );
                ScoreManager.Instance.AddBinCount();
            }
            CountDown.instance._obj.Remove(collision.gameObject);
            Destroy(collision.gameObject);
            CountDown.instance.objremain--;   
        }
    }
}
