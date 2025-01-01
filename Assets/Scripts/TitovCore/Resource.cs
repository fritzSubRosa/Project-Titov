using System;
using TMPro;


namespace TitovCore
{
    [Serializable]
    public class Resource
    { 
        private int value;
        private int maxValue;

        private TMP_Text UIValue;
        private TMP_Text UIMaxValue;

        public Resource(int value, int maxValue, TMP_Text uiValue, TMP_Text uiMaxValue)
        {
            this.value = value;
            this.maxValue = maxValue;
            
            this.UIValue = uiValue;
            this.UIMaxValue = uiMaxValue;
            UpdateUI();
        }

        private void UpdateUI()
        {
            this.UIValue.text = this.value.ToString();
            this.UIMaxValue.text = this.maxValue.ToString();
        }
         
        public int Value { get { return value; } }
        public int MaxValue { get { return maxValue; } }

        public void AddValue(int amount)
        {
            if (amount + value <= maxValue)
            {
                value += amount;
            }
            else
            {
                value = maxValue;
            }
            UpdateUI();
        }

        public void SpendValue(int amount)
        {
            if (amount - value >= 0)
            {
                value -= amount;
                UpdateUI();
            }
            else return; 
        }

        public void LoseValue(int amount)
        {
            value -= amount; 
            UpdateUI();

        }

        public void IncreaseMax(int amount)
        {
            maxValue += amount;
            UpdateUI();

        }
        
        public void DecreaseMax(int amount)
        {
            if (maxValue - amount >= 0)
            {
                maxValue -= amount;
                if (value > maxValue)
                {
                    value = maxValue;
                }
            }
            else 
            {
                maxValue = 0;
                value = 0;
            }
            UpdateUI();
        }
    }
}