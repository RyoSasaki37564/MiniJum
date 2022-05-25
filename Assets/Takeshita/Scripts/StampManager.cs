using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StampManager : MonoBehaviour
{
    [SerializeField, Tooltip("スタンプのプレハブ")]
        GameObject _stamp;
    [SerializeField, Tooltip("スタンプ発動に必要なポイント")]
        int _requiredPoint;
    [SerializeField, Tooltip("ためておけるスタンプの数")]
        int _stockCapacity;

    [Tooltip("現在のポイント")]
        private int _point;

    public void ChargePoint(int getPoint)
    {
        _point += getPoint;

        if (_point > _requiredPoint * _stockCapacity)
        {
            _point = _requiredPoint * _stockCapacity;
        }
    }

    private bool IsCharged()
    {
        return _point >= _requiredPoint;
    }

    public void Shot()
    {
        if(IsCharged())
        {
            Instantiate(_stamp, this.transform.position, Quaternion.identity);
            _point -= _requiredPoint;
        }
    }
}
