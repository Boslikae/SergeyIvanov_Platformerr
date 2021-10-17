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

    	private SpriteAnimatorController _playerAnimator;
        private CameraController _cameraController;
        private PlayerController _playerController;

    	void Start()
    	{
        	_playerConfig = Resources.Load<SpriteAnimatorConfig>("PlayerAnimCfg");
        	if(_playerConfig)
        	{
        		_playerAnimator = new SpriteAnimatorController(_playerConfig);
                _playerController = new PlayerController(_playerView, _playerAnimator);
        	}

            _cameraController = new CameraController(_playerView.transform, Camera.main.transform);
    	}

    	void Update()
    	{
            _cameraController.Update();
            _playerController.Update();
    	}
	}
}