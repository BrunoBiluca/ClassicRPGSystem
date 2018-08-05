using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    private GameObject[] heros;
    private GameObject[] enemies;

    private Text heroHp;
    private Text enemyHp;

    private bool heroTurn = true;
    private int attackOrder = 0;
	// Use this for initialization
	void Start () {
	    heros = GameObject.FindGameObjectsWithTag(TagsEnum.Hero);
	    enemies = GameObject.FindGameObjectsWithTag(TagsEnum.Enemy);
	    Debug.Log($"Hero number: {heros.Length}");
	    Debug.Log($"Enemy number: {enemies.Length}");

	    heroHp = GameObject.Find("HeroHP").GetComponent<Text>();
	    enemyHp = GameObject.Find("EnemyHP").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (!Input.GetKeyDown(KeyCode.Space)) return;

	    var hero = heros[attackOrder].GetComponent<HeroController>();
	    var enemy = enemies[attackOrder].GetComponent<EnemyController>();

        if (heroTurn) {
            var attackCommand = new Attack(hero.Model, enemy.Model);
            attackCommand.Execute();

	        enemyHp.text = $"{enemies[attackOrder].name} has HP {enemy.Model.Health}";
	    }
	    else {
            var defenseCommand = new Defense(enemy.Model);
            defenseCommand.Execute();
	        Debug.Log($"{enemies[attackOrder].name} has attack");
            heroHp.text = $"{heros[attackOrder].name} has HP {hero.Model.Health}";
            //attackOrder++;
            //if (attackOrder > heros.Length - 1) attackOrder = 0; 	        
        }
        
	    heroTurn = !heroTurn;
	}
}
