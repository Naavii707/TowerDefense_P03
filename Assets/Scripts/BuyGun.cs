using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BuyGun : MonoBehaviour
{
    [SerializeField]
    private int _gunCost = 100;
    [SerializeField]
    private InstanciatePullObject _gunPoolObject;
    [SerializeField]
    private CoinsNumber _coisNumber;
    [SerializeField]
    private UnityEvent<Transform> _onGunPurchased;
    [SerializeField]
    private Text _costText;
    private void Start()
    {
        _costText.text = _gunCost.ToString();
    }

    public void TryBuyGun()
    {
        if (_coisNumber.BuyObject(_gunCost))
        {
            _gunPoolObject.InstanciateObject(transform);
            GameObject gun = _gunPoolObject.GetCurrentGameObject();
            _onGunPurchased?.Invoke(gun.transform);
        }
    }
}
