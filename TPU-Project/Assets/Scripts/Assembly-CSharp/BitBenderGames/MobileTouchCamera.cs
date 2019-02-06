using UnityEngine;

namespace BitBenderGames
{
	public class MobileTouchCamera : MonoBehaviourWrapped
	{
		[SerializeField]
		private CameraPlaneAxes cameraAxes;
		[SerializeField]
		private PerspectiveZoomMode perspectiveZoomMode;
		[SerializeField]
		private float camZoomMin;
		[SerializeField]
		private float camZoomMax;
		[SerializeField]
		private float camOverzoomMargin;
		[SerializeField]
		private float camOverdragMargin;
		[SerializeField]
		private Vector2 boundaryMin;
		[SerializeField]
		private Vector2 boundaryMax;
		[SerializeField]
		private float camFollowFactor;
		[SerializeField]
		private AutoScrollDampMode autoScrollDampMode;
		[SerializeField]
		private float autoScrollDamp;
		[SerializeField]
		private AnimationCurve autoScrollDampCurve;
		[SerializeField]
		private float groundLevelOffset;
		[SerializeField]
		private bool enableRotation;
		[SerializeField]
		private bool enableTilt;
		[SerializeField]
		private float tiltAngleMin;
		[SerializeField]
		private float tiltAngleMax;
		[SerializeField]
		private bool enableZoomTilt;
		[SerializeField]
		private float zoomTiltAngleMin;
		[SerializeField]
		private float zoomTiltAngleMax;
		[SerializeField]
		private UnityEventWithRaycastHit OnPickItem;
		[SerializeField]
		private UnityEventWithRaycastHit2D OnPickItem2D;
		[SerializeField]
		private UnityEventWithRaycastHit OnPickItemDoubleClick;
		[SerializeField]
		private UnityEventWithRaycastHit2D OnPickItem2DDoubleClick;
		[SerializeField]
		private bool expertModeEnabled;
		[SerializeField]
		private float zoomBackSpringFactor;
		[SerializeField]
		private float dragBackSpringFactor;
		[SerializeField]
		private float autoScrollVelocityMax;
		[SerializeField]
		private float dampFactorTimeMultiplier;
		[SerializeField]
		private bool isPinchModeExclusive;
		[SerializeField]
		private float customZoomSensitivity;
		[SerializeField]
		private TerrainCollider terrainCollider;
		[SerializeField]
		private Transform cameraTransform;
		[SerializeField]
		private float rotationDetectionDeltaThreshold;
		[SerializeField]
		private float rotationMinPinchDistance;
		[SerializeField]
		private float rotationLockThreshold;
		[SerializeField]
		private float pinchModeDetectionMoveTreshold;
		[SerializeField]
		private float pinchTiltModeThreshold;
		[SerializeField]
		private float pinchTiltSpeed;
	}
}
