using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnSphere : MonoBehaviour
{
	public GameObject prefab;
	public ARSessionOrigin origin;
	public float spawnSize = 0.5f;

	public void OnClick() {
		var go = Instantiate(prefab);
		var l = origin.transform.localPosition;
		go.transform.localPosition = new Vector3(l.x, l.y, l.z + 2);
		go.transform.localScale = new Vector3(spawnSize,spawnSize,spawnSize);
		go.transform.parent = origin.transform;
		go = Instantiate(prefab);
		go.transform.localPosition = new Vector3(l.x, l.y, l.z - 2);
		go.transform.localScale = new Vector3(spawnSize,spawnSize,spawnSize);
		go.transform.parent = origin.transform;
	}
}
