using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadingController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UserDataManager.Load();
        SceneManager.LoadScene(1);
    }
}
