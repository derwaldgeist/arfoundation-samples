﻿using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SwapCamera : MonoBehaviour
{
	public ARSession arSession;
	public ARCameraManager arCameraManager;
	public ARFaceManager arFaceManager;

	public void Swap() {
		if (arCameraManager.currentFacingDirection == CameraFacingDirection.World) {
			SetCameraFacingDirection(CameraFacingDirection.User);
		} else {
			SetCameraFacingDirection(CameraFacingDirection.World);
		}
	}

	public void SetCameraFacingDirection(CameraFacingDirection direction) {
		if (direction == CameraFacingDirection.User) {
			SpawnSphere.instance.Hide();
			arCameraManager.requestedFacingDirection = CameraFacingDirection.User;
			arFaceManager.enabled = true;
		} else {
			SpawnSphere.instance.Show();
			arFaceManager.enabled = false;
			arCameraManager.requestedFacingDirection = CameraFacingDirection.World;
			arSession.requestedTrackingMode = TrackingMode.PositionAndRotation;
		}
	}
}
