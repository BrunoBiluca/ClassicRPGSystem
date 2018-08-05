using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Esta classe é responsável por determinar o comportamento de render e instanciar a lógica do inimigo
/// </summary>
public class EnemyController : MonoBehaviour {

    public Enemy Model { get; private set; }

	// Use this for initialization
	void Start () {
		Model = new Enemy(4, 2);
	}

    void LateUpdate() {
        if (Model.IsInDefenseState()) {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
