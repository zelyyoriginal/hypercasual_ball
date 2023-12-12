using UnityEngine;
using UnityEngine.Events;

public class Triger : MonoBehaviour
{
    [SerializeField] private string _tag;
    public UnityEvent action;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == _tag)
        {
            action?.Invoke();
        }
    }
}
