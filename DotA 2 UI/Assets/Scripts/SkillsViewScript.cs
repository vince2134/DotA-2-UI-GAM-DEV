using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsViewScript : MonoBehaviour {

    [SerializeField] private GameObject SkillsView;
    [SerializeField] private GameObject HeroesView;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackToHeroesView()
    {
        SkillsView.SetActive(false);
        HeroesView.SetActive(true);
    }
}
