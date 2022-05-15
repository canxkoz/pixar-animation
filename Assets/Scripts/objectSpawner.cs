using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objectSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject P;
    public GameObject I;
    public GameObject X;
    public GameObject A;
    public GameObject R;
    public GameObject Lamp;
    Scene pixarScene;

    private void Awake()
    {
        pixarScene = SceneManager.GetActiveScene();
    }
    public void SpawnP()
    {
        Instantiate(P, spawnPoint.position, Quaternion.Euler(0f, -90f, 0f));
    }
    public void SpawnI()
    {
        Instantiate(I, spawnPoint.position, Quaternion.Euler(0f, -90f, 0f));
    }
    public void SpawnX()
    {
        Instantiate(X, spawnPoint.position, Quaternion.Euler(0f, -90f, 0f));
    }
    public void SpawnA()
    {
        Instantiate(A, spawnPoint.position, Quaternion.Euler(0f, -90f, 0f));
    }
    public void SpawnR()
    {
        Instantiate(R, spawnPoint.position, Quaternion.Euler(0f, -90f, 0f));
    }
    public void SpawnLamp()
    {
        Instantiate(Lamp, spawnPoint.position, Quaternion.identity);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(pixarScene.name);
    }

}
