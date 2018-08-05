using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

    [SerializeField] public Hero Model { get; private set; }

	// Use this for initialization
	void Start () {
		Model = new Hero(5, 2);
	}
}
