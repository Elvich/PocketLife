using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashSave : MonoBehaviour
{
    private int _condition;
    private List<Income> _income = new();
    private List<Expenses> _expenses = new();



    private void Save()
    {
        PlayerPrefs.SetString("CashSave", JsonUtility.ToJson(this));
    }

    private void Load()
    {
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("CashSave"), this);
    }



    public int RequestCondition()
    {
        return _condition;
    }

    public List<Income> RequestIncome()
    {
        return _income;
    }

    public List<Expenses> RequestExpenses()
    {
        return _expenses;
    }


    public void SendData(int newCondition)
    {
        _condition = newCondition;
    }

    public void SendData(List<Income> newIncome)
    {
        _income = newIncome;
    }

    public void SendData(List<Expenses> newExpenses)
    {
        _expenses = newExpenses;
    }
}
