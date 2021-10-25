using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVC
{

	public class Main : MonoBehaviour
	{
    	[SerializeField] private SpriteAnimatorConfig _playerConfig;
    	[SerializeField] private int _animationSpeed = 10;
    	[SerializeField] private LevelObjectView _playerView;
        [SerializeField] private CanonView _canonView;

    	private SpriteAnimatorController _playerAnimator;
        private CameraController _cameraController;
        private PlayerController _playerController;
        private CanonController _canon;
        private BulletEmitterController _bulletEmitterController;

    	void Start()
    	{
        	_playerConfig = Resources.Load<SpriteAnimatorConfig>("PlayerAnimCfg");
        	if(_playerConfig)
        	{
        		_playerAnimator = new SpriteAnimatorController(_playerConfig);
                _playerController = new PlayerController(_playerView, _playerAnimator);
        	}

            _cameraController = new CameraController(_playerView.transform, Camera.main.transform);
            _canon = new CanonController(_canonView._muzzleTransform, _playerView._transform);
            _bulletEmitterController = new BulletEmitterController(_canonView._bullets, _canonView._emitterTransform);
    	}

    	void Update()
    	{
            _cameraController.Update();
            _playerController.Update();
            _canon.Update();
            _bulletEmitterController.Update();
    	}
	}
}