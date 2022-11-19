using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private int _countBeats;
    
    
    private Animator _animator;
    
    private static readonly int Forward = Animator.StringToHash("Forward");
    private static readonly int Back = Animator.StringToHash("Back");
    private static readonly int RandomHit = Animator.StringToHash("RandomHit");
    private static readonly int Hit = Animator.StringToHash("Hit");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetTrigger(Forward);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _animator.SetTrigger(Back);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetFloat(RandomHit, Random.value);
            _animator.SetTrigger(Hit);
        }
    }
}
