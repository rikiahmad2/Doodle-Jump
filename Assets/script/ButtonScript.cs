using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    private void Start()
    {
        Button btn2 = GameObject.Find("Exit").GetComponent<Button>();
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(Clicker);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Clicker()
    {
        Debug.Log("Clicked");
        Application.Quit();
    }
}
