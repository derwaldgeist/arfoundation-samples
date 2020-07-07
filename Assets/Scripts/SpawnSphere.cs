using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnSphere : MonoBehaviour
{
	public static SpawnSphere instance;
	public GameObject prefab;
	public ARSessionOrigin origin;
	public float spawnSize = 0.5f;
	GameObject sphere;

	void Awake() {
		instance = this;
	}

	public void OnClick() {
		sphere = Instantiate(prefab);
		var l = origin.transform.localPosition;
		sphere.transform.localPosition = new Vector3(l.x, l.y, l.z + 2);
		sphere.transform.localScale = new Vector3(spawnSize, spawnSize, spawnSize);
		sphere.transform.parent = origin.transform;
	}

	public void Hide() {
		sphere.gameObject.SetActive(false);
	}
	public void Show() {
		sphere.gameObject.SetActive(true);
	}
}
