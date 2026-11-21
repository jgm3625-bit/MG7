using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private Bird[] _sparrow;
    [SerializeField] private Transform _player;
    [SerializeField] private float _interactDistance = 10.0f;
    private void Update()
    {
        for (int i = 0; i < _sparrow.Length; i++)
        {
            Bird bird = _sparrow[i];
            if (Vector3.Distance(bird.transform.position, _player.position) < _interactDistance) 
            {
                bird.gameObject.SetActive(true);
            }
        }
        
    }
}
