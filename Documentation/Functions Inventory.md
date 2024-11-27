@Shahrom - this is a companion note to the new JSON format for actions / milestones / objectives. I think it makes the most sense to create a set of functions that act upon cards, and have the cards themselves just point to those functions (if that makes sense). I'm compiling a list/description of those functions below. this is a WIP - feel free to add comments/questions/details.


Gain_Food
	Gain 1 Food to the bank, if possible
Gain_Influence
	 Gain 1 Influence to the bank, if possible
Gain_Stability
	 Gain 1 Stability to the bank, if possible
Gain_Might
	 Gain 1 Might to the bank, if possible
Gain_Trade_Good
	 Gain 1 Trade Good to the bank, if possible

Spend_Food
	 Spend 1 Food, if possible
Spend_Influence
	 Spend 1 Influence, if possible
Spend_Stability
	 Spend 1 Stability, if possible
Spend_Might
	 Spend 1 Might, if possible
Spend_Trade_Good
	 Spend 1 Trade Good, if possible

Advance_Tax_Unrest
	 Advance a global Unrest counter, which will be visualized on Tax Collection cards

Advance_Admin_Unrest
	 Advance a global Unrest counter which will be visualized on Zealous Administration cards.


