using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLogicMainMenu : MonoBehaviour
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
