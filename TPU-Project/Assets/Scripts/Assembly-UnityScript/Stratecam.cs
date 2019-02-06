using System;
using UnityEngine;

[Serializable]
public class Stratecam : MonoBehaviour
{
	public Terrain terrain;
	public float panSpeed;
	public float zoomSpeed;
	public float rotationSpeed;
	public float mousePanMultiplier;
	public float mouseRotationMultiplier;
	public float mouseZoomMultiplier;
	public float minZoomDistance;
	public float maxZoomDistance;
	public float smoothingFactor;
	public float goToSpeed;
	public bool useKeyboardInput;
	public bool useMouseInput;
	public bool adaptToTerrainHeight;
	public bool increaseSpeedWhenZoomedOut;
	public bool correctZoomingOutRatio;
	public bool smoothing;
	public bool allowDoubleClickMovement;
	public bool allowScreenEdgeMovement;
	public int screenEdgeSize;
	public float screenEdgeSpeed;
	public GameObject objectToFollow;
	public Vector3 cameraTarget;
}
