using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillLoaderScript : MonoBehaviour {

    [SerializeField] private GameObject SkillsView;
    [SerializeField] private GameObject HeroesView;

    [SerializeField] private Text HeroName;
    [SerializeField] private Text HeaderText;

    [SerializeField] private Image Skill1;
    [SerializeField] private Image Skill2;
    [SerializeField] private Image Skill3;
    [SerializeField] private Image Skill4;

    [SerializeField] private Sprite Skill1Spr;
    [SerializeField] private Sprite Skill2Spr;
    [SerializeField] private Sprite Skill3Spr;
    [SerializeField] private Sprite Skill4Spr;

    [SerializeField] private Text Skill1Desc;
    [SerializeField] private Text Skill2Desc;
    [SerializeField] private Text Skill3Desc;
    [SerializeField] private Text Skill4Desc;

    [SerializeField] private Text Skill1Text;
    [SerializeField] private Text Skill2Text;
    [SerializeField] private Text Skill3Text;
    [SerializeField] private Text Skill4Text;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowSkills()
    {
        SkillsView.SetActive(true);
        HeroesView.SetActive(false);

        Skill1.sprite = Skill1Spr;
        Skill2.sprite = Skill2Spr;
        Skill3.sprite = Skill3Spr;
        Skill4.sprite = Skill4Spr;

        Skill1Text.text = Skill1Desc.text;
        Skill2Text.text = Skill2Desc.text;
        Skill3Text.text = Skill3Desc.text;
        Skill4Text.text = Skill4Desc.text;

        HeaderText.text = HeroName.text;

        print("abaddon");
    }
}
