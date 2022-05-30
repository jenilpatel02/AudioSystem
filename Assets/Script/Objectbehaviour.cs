using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Objectbehaviour : MonoBehaviour
{
    public string objname;
    public ObjType objtype;
    public int BasketScore;
    public int scoring;
    public Image sprite;
    public enum ObjType
    {
        Fruit,
        Accessory,
        Trekking
    }
    int End;
    void Start()
    {
    BasketScore = 1;
    scoring = 5;
    objname = gameObject.name;
    GetComponent<BoxCollider2D>();
    }
}