using UnityEngine;
using UnityEngine.UI;

public class ShowButton : MonoBehaviour
{
    public GameObject Player;
    public GameObject button;
    public bool collided;
    public Task task;

    private void Start()
    {
        collided = false;
    }

    private void Update()
    {
        if (collided == true)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == Player)
        {
            collided = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject == Player)
        {
            collided = false;
        }
    }
}
