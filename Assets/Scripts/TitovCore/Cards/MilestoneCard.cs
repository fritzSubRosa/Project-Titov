using UnityEngine;
using TMPro;

namespace TitovCore.Cards
{
    public class MilestoneCard : MonoBehaviour
    {
        public int timer = -1; // -1 implies there is no timer  
        public int timerElapsed = -1;  
        [SerializeField] TextMeshProUGUI code; 
        [SerializeField] TextMeshProUGUI title;
        [SerializeField] TextMeshProUGUI flavorText;

        private void Start()
        {
            Code = code?.text;
            Title = title?.text;
            FlavorText = flavorText?.text; 
            Type = CardType.Milestone;
        }

        public CardType Type { get; protected set; }

        public string Code { get; protected set; }

        public string Title { get; protected set; }

        public string FlavorText { get; protected set; }

        public void UpdateTimer(int value)
        {
            // value can be positive or negative, based on whether you are incrementing timer or decrementing. 
            if (timer > 0 && timerElapsed > 0)
            {
                timerElapsed += value;
            }
        }

        public void SetupCard(Card card)
        {
            if (card.type != CardType.Milestone) return;
            Code = card.code;
            Title = card.title;
            FlavorText = card.flavorText ?? "";
        }
        
        // The function to be overrided by every individual card
        public virtual void ResolveCard()
        {
            Debug.Log("Card::ResolveCard -- Card Resolved.");
        }
    }
}