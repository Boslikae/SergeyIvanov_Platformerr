using System;
using UnityEngine;

namespace PlatformerMVC
{

	public class LevelObjectView : MonoBehaviour
	{
		public Transform _transform;
		public SpriteRenderer _spriteRenderer;
		public Collider2D _collider;
		public Rigidbody2D _rigidbody;

    	void Start()
    	{
    	 	 _transform = GetComponent<Transform>();
    	 	 _spriteRenderer = GetComponent<SpriteRenderer>();
    	 	// _collider = GetComponent<Collider2D>();
    	 	// _rigidbody = GetComponent<Rigidbody2d>();

    	}

	}	

}