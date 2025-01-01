# Project Titov 
Stephen's MA Thesis 

- GitHub Repo [**Here**](https://github.com/fritzSubRosa/Project-Titov)
- Figma Designs [**here**](https://www.figma.com/files/team/1361752131146014945/project/291665647/Titov?fuid=1112098330417764190)
	- Need a design for the way the screen should look. 
- Core documentation [**here** ](https://docs.google.com/document/d/1GVJo-9sSJmY4QaGXMs7jXraMOZ1r0mvQSRll1GaJVhc/edit?tab=t.0)
	- This has been written down in this file and should be considered deprecated.  
## Index 
1. [Features](./Features.MD)
2. [Questions](./Questions.MD) -- file for us to leave questions to be answered later or by the other. 
3. [[#Core Mechanics]]
4. [Play Areas](#Play-Areas)
5. [Cards](#Cards)
	1. [Card Types](#Types)
	2. [Card Subtypes](#Subtypes)
	3. [Keywords](#Keywords)
	4. [List of Cards](#List-of-Cards)
6. [Phases](#Phases)
	1. [Action Phase](#Action-Phase)
	2. [Crisis Phase](#Crisis-Phase)
	3. [Reset Phase](#Reset-Phase)
7. [System](./Systems.MD) -- This is for MSA to think through the implementation 
8. [State](./State.MD) -- This is for a place to think about what will be the state to track, save, load, reset. 
## Core Mechanics 
1. Cards
	1. Drawing a card 
	2. Playing a card 
	3. Card Effects 
	4. Gaining Cards
2. Resources 
	1. Gaining Resource
	2. Losing Resource
	3. Spending Resource
3. Timers 
	1. Advancing timers
	2. Triggering Timers
4. Objectives
	1. Resolving Objectives (progressing in story)
5. ## Game Setup 
## Timing Structure
1. Action Phase
	1. The only phase in which the player may play **Action Cards**, unless otherwise indicated. Progresses as follows. 
	2. Draw 5 **Action Cards**
		1. This amount can increase or decrease due to temporary or permanent effects.
	3. Play a card from hand, doing the following in order:
		1. **Spend** the **resource** in the top-right hand corner of the **Action Card**
		2. If the **Action Card** has the **Province** subtype, check if the printed inequality is true.
			1. If it is true, resolve the indicated effect.
			2. If it is not true, resolve the "ELSE" effect
		3. Gain **resources** or **cards**, as appropriate.
		4. If there is a **clock** on the card, **advance** it.
			1. If the **clock** is full, resolve the indicated effect, then empty the **clock**.
		5. If the card has the **Expendable** subtype, **destroy** it.
	4. The player may repeat step 3 as many times as they have **Action Cards** in **hand** or choose to end their **Action Phase**. When the player ends their **Action Phase**, proceed to step 5.
		1. They may not end their **Action Phase** if there are any any **Action Cards** with the **Mandatory** subtype in their **hand**. 
	5. When the player ends their **Action Phase**, do the following in order:
		1. Resolve any **Retained** effects on **Action Cards** still in the **hand**.
		2. **Destroy** any **Action Cards** that have the **Seasonal** subtype.
		3. Move all remaining **Action Cards** in hand into the **Action Discard**.
		4. Proceed to the **Crisis Phase**.
2. Crisis Phase
	1. During the **Crisis Phase**, the player may take a **Resolution** to any number of **Objectives** or **Milestones**, provided they satisfy the **Resolution Requirements** thereof.
		1. **Objectives** and **Milestones** can be resolved one of three ways: by the player **spending** **resources**, performing a certain task during their previous **Action Phase** or by achieving a given game state. Examples of each are given below.
			1. *Spending Resources*: The player may **spend** 4 **Influence** to resolve M1: The Long Exile by choosing the "Enlist their soldiers" **Resolution**. Alternatively, they may **Spend** 4 **Stability** to resolve the **Milestone** with the "Integrate their nobility" **Resolution**.
			2. *Achieving Game State*: The player may resolve M3: The Turn of the Wheel with the "Gather a coalition" **Resolution** by **controlling** 3 **Action Cards** with the **Province** subtype. 
			3. *Achieving a Task*: The player may resolve O1: Ritualized Taxation if, during their previous **Action Phase**, they gained at least 2 **Food** and 1 **Stability** by taking the "Organize annual tithes" **Resolution.**
		2. Once a **Resolution** has been taken, its effects take place immediately.
			1. When a player resolves an **Objective** or **Milestone**, they immediately gain any indicated **Resources**, **Action Cards**, or **Objectives**. This means the player may use resources gained by resolving one **Objective** to resolve another during the same **Crisis Phase**. 
				1. Eg. Hatshepsut wishes to resolve O7: Debt Jubilee by taking the "Forgive Peasant Debts" option. However, she lacks the **Food** to do so. O11: Raid Beyond the Cataracts is also in her **Agenda**, however, and she has enough **Might** to resolve it by taking the "Lead a punitive expedition" **Resolution**. She therefore resolves O11: Raid beyond the Cataracts first, gaining 4 **Food.** She then spends 3 of that **Food** to take the "Forgive peasant debts" **Resolution** of O7: Debt Jubilee and gain one **Stability**.
			2. If the chosen **Resolution** contains the **return** (↩️) symbol, the **Objective** is placed in the **Objective Discard.** Otherwise, it is **destroyed.**
		3. The player may choose to end their **Crisis Phase** at any time. When they do, proceed to the **Reset Phase**.
3. Reset Phase (Note: Digitally, this should all be automatic)
	1. Perform the following, in order:
		1. **Advance** the **timer** on every **Milestone** and **Objective** still in play. 
		2. If **advancing** the timer of an **Objective** or **Milestone would** fill it, do the following:
			1. *Milestone*: Perform the action indicated next to the **timer**. Then, empty the **timer**. Do not remove the **Milestone**. Do not draw an additional **Milestone**.
				1. Eg. If the player does not take either **Resolution** to M1: The Long Exile in 3 turns, they **gain** a copy of Border Raid to their **Objective Discard.** The **timer** is then reset back to 0.
			2. *Objective*: Perform the action indicated next to the **timer**. If this text contains the **return** symbol (↩️), move the **Objective** to the **Objective Discard.** Otherwise, **destroy** the **Objective.**
		3. If there is no active **Milestone**, reveal the top card of the **Milestone Deck**.
		4. Fill each empty space in the **Agenda** by drawing a card off the top of the **Objective Deck** and placing it in the **Agenda** face up. 
			1. If the **Objective Deck** is empty, shuffle the **Objective Discard** and place it face down as a new **Objective Deck.** Then, resume the above. 
		5. Resume play with the next turn's **Action Phase.**

## Cards
### Types
1. **Milestone Cards**: 
	- The main quest. 
	- Resolved in order, from M01 until end - See [List of Cards](#List-of-Cards) subheading below
1. **Action cards**: 
	- Cards played from the **hand**. 
	- These go into the **Action Discard** once played or when **Action Phase** is ended. 
2. **Objective Cards**: 
	- Side Quests and Deck Building opportunities. 
	- Placed face-up into an Agenda.

### Subtypes
1. Expendable
	1. If this card is played during the **Action Phase**, it is **destroyed**
2. Industry 
	1. Complex industry, handicrafts, and production. 
	2. Generally used to **improve action cards**
	3. Requires **trade goods**. 
3. Ma'at
	1. The cycle of the seasons, the favour of the gods. 
	2. Generally used to gain **stability**. 
4. Monument 
	1. Power writ in stone and brick. 
	2. Generally the result of a **project** and yields **Stability** and **Influence** 
5. Misfortune
	1. Calamities, great and small. 
	2. Gained by card effects or by **resource** debt.
	3. Multiple copies of the same card usually **fuse** together into worse, more dangerous forms. 
6. Mandatory 
	1. This card must be played during the **Action Phase** and may not remain in **hand**.
7. Province 
	1. Tributaries, outposts, and vassals. 
	2. Costs no **resources** to play but checks the sum of two **resources**.
	3. Gains additional **resources** if the sum is above a certain threshold. 
8. Seasonal
	1. If this card remains in hand at the end of the **Action Phase**, it is **destroyed**
9. Statecraft 
	1. The operations of state, the exercise of power. 
	2. Generally **draws** cards or gains **Influence** or **Food**.  
10. Trade 
	1. The lifeblood of empires, the cords that bind kings. 
	2. Gains trade goods at the expense of food but is usually seasonal. 
11. Troop
	1. Sailors, soldier, and sellswords. 
	2. Generally costs **food** and gains **might** or more rarely **influence** or **stability**. 
	3. Professional troops have **retained** costs - fail to pay them at your peril. 

### Keywords
1. Action Deck 
	1. The **Action Cards** that are yet to be drawn. 
	2. Can be looked at, but the order is obscured. 
3. Advance 
	1. Fill in one slice of an active **timer** or **clock**
4. Agenda 
	1. The space at the *top of the screen* with slots for **Objectives**
	2. Starts with 3 slots, and increases over time.  
5. Bank 
	1. The player's current amount of each resource 
6. Calamity
	1. An **Objective Card** representing an acute, potentially escalating, crisis. Each is associated with a specific **Resource**. When a player would **lose** a **resource** they do not have, they **gain** a copy of the Calamity associated with that **resource** to their **Objective Discard.**
		1. **Might** - "Border Raid"
		2. **Influence** - "Diplomatic Incident"
		3. **Food** - "Crop Failure"
		4. **Stability** - "Whispers of Treason"
7. Control
	1. The player **controls** all **Action Cards** which are in the **Action Deck**, **Hand**, and **Action Discard**.
8. Clock 
	1. A pie-chart divided into 2, 3, 4, or 6 slices 
	2. Has an effect when full. 
	3. Can be **advanced** by certain card effects 
	4. When on an Action Card, generally indicates the number of times that card (by card name) has been played.  
9. Crisis `[x], [y:z], [⏳:a]`
	1. A political conflict
	2. Measured on a scale of 0 to 6-10, starting at `x`. 
	3. Decreases by `a` every turn. 
	4. Increases by `z` for every `y` of a resource spent.
10. Delay `[x]`
	1. Reduce the progress of any **timer** by 1, `x` number of times. 
11. Destroy 
	1. Permanently remove this card from play 
12. Disrupt `[x]`
	1. Discard the top `x` cards of the **Action Deck** 
13. Draw `[x]`
	1. Add the top `x` cards of the **Action Deck** to the **Hand** 
14. Foresee `[x]` -- swapped with "Scout"
	1. Look at the top `x` cards of the **Action Deck**
	2. You may add one of these cards to **hand**.
15. Escalation `[x]` -- NB this has been renamed from "Fusion" to "Escalation." It is mechanically exactly the same.
	1. If 2 cards of the same name with fusion are in the **Agenda** at the same time, they are both **destroyed** and **replaced** by one copy of `x`. 
	2. Draw an additional **Objective** to fill any ensuing empty space in the **Agenda**. 
16. Gain `[`resource or card`]`
	1. *Gain Resource:* 
		1. Increase the bank of the indicated **resource** by the indicated amount. 
		2. Any amounts above the **max** are lost. 
	2. *Gain action card:*
		1. Add the indicated card to the **Action Discard**
	3. *Gain action card to hand*
		1. Add the indicated card to the **hand**
	4. *Gain objective card:*
		1. Add the indicated card to the **Objective Discard**
	5. *Gain objective card to deck*
		1. Add the indicated card to the **Objective Deck**
17. Gain `[x]` to hand 
	1. Add the indicated card to **hand**. 
18. Hand 
	1. The array of **available Action Cards**. 
	2. Indicated at the *bottom of the screen*.
19. Immediate 
	1. Resolve this effect as soon as the card is **drawn** (for Action Cards) or placed in the **agenda** (for Objectives)
20. Improve
	1. Increase the **resources** produced by this card by 2. -- NB this may no longer be true, but keep it for now.
	2. The card now also costs 1 **trade good** to play. 
21. Loop(♻️)
	1. When this **timer** is full, empty it. 
	2. Do not remove the card from play. 
22. Lose `[x]`
	1. Reduce the indicated **resource bank** by the indicated amount. 
	2. If this would make the **bank** negative, add one **Calamity** of that resource type for each **resource** the **bank** would be in deficit of.  
23. Milestone Deck 
	1. The **Milestone Cards** that have yet to enter play 
	2. Not Searchable.
24. Milestone Discard 
	1. Where **Milestones** that have been resolved in the **Crisis Phase** go during the **Reset Phase**.
	2. Searchable
25. Objective Deck 
	1. The **Objective Cards** that have yet to enter play. 
	2. Not searchable
26. Objective Discard 
	1. Where **Objective Cards** are sent if they either have the **return** keyword or have been **gained** due to a card effect. 
27. Recur `[x]`
	1. Add `x` cards from the **Action Discard** to the **Hand**. 
28. Replace 
	1. **Destroy** this card and place the indicated card in its place. 
29. Resources 
	1. Food (🌾)
		1. Essential for the life of body and state alike. 
		2. Generally gained through **Statecraft** or **Provinces**
	2. Stability 
		1. Political continuity, Public opinion.
		2. Generally gained through **Ma'at** and **Monuments**
	3. Influence
		1. Prestige, Political cachet.
		2. Generally gained through **Statecraft**, **Monuments**, and certain **Troops**
	4. Might 
		1. Military Prowess; power projection. 
		2. Generally gained through **Troops**
	5. Trade Goods 
		1. Tin, gold, copper - The essentials of sophisticated economic life. 
		2. Generally gained through Trade. 

30. Reshuffle `[x]`
	1. Shuffle `x` **Action Cards** from the **Action Discard** into the **Action Deck**
31. Resolution
	1. A course of action, indicated on an **Objective** or **Milestone** by a gray gray background and black border. Each **Resolution** has **Resolution Requirements** and one or more effects.
32. Resolution Requirements
	1. A statement that determines if a given **Resolution** can be taken by the player during their **Crisis Phase**. Can involve the player **spending** **resources**, having certain **Action Cards** in their **control**, or performing a certain task during their previous **Action Phase.**
33. Return (↩️)
	1. Add this card to the **Objective Discard**
34. `[x]` Max 
	1. The maximum amount of `x` **Resources** that the **bank** can contain. 
	2. **Resources** gained above this amount are lost. 
35. Project `[x],[y:z]`
	1. A long-term effort, measured on a scaled from 0 to `x`, usually 8 - 10. 
	2. Starts at 0. 
	3. Expending `y` of a **resource** yields `z` progress. 
	4. When full, usually **replaced** by another card.  
36. Reshuffle `[x]`
	1. Shuffle `x` cards from the **Action Discard** into the **Action Deck**. 
37. Retained 
	1. Resolve this effect if the card is still in **hand** and the end of the **Action Phase**
38. Scout `[x]`
	1. Look at the top `x` cards of the **Objective Deck**. You may place one of these cards on the bottom of the **Objective Deck**
39. Spend `[x]`
	1. Reduce the **bank** of the indicated resource by `x`
	2. You may not **spend resources** you do not possess. 
	3. But you can **lose** more than you possess. 
40. Timer (⏳)
	1. A **clock** that progresses by 1 every **Reset Phase**
41. War `[x], [y:z], [a]`
	1. An armed conflict measured on a scale of 0 to 4-10.
	2. Starts at `x`
	3. Decreases by `a` every turn
	4. Increases by `z` for every `y` of the indicated **resource** spent (usually **Might**)
### List of Cards

1. Milestone cards 
	1. M1 - The Long Exile 
	2. M2 - Ways of War 
	3. M3 - Turn of the Wheel 
	4. M4 - The Siege of Esh-Edu
	5. M5 - Fate of the Wheel-Turners 
	6. M6 - Uniting the Two Lands 
	7. M7 - Act II 
	8. M8 - Across the Great Green 
	9. M9 - The Sun King 
	10. M10 - The Old Order 
	11. M11 - Groom of the Sun 
	12. M12 - Legacy of the Sun King 
	13. M15 - Shadow of the Sun King 
	14. M18 - EMPTY 
	15. M19 - Gold Legacy 
	16. M20 - Conqueror Legacy 
2. Action Cards 
	1. C1 - Tax Collection 
	2. C2 - Conscription 
	3. C3 - Levy Infantry 
	4. C4 - Public Rituals 
	5. C5 - Diplomatic Overtures 
	6. C6 - State Rituals 
	7. C7 - Royal Guard 
	8. C8 - Court Intrigue 
	9. C9 - Corruption 
	10. C10 - Blood Money 
	11. C11 - Hill Country Conscription 
	12. C12 - Hill Country Couriers 
	13. C13 - Hill Country Archers 
	14. C14 - Exorbitant Gift 
	15. C15 - Border Fort 
	16. C16 - Trading Post 
	17. C17 - Moon God Sacrifices 
	18. C18 - Corvee 
	19. C19 - Volunteers 
	20. C20 - Seditious Priests 
	21. C21 - Cataracts Vassal 
	22. C22 - Cataracts Vassal
	23. C23 - Sable Coast Vassal 
	24. C24 - Sable Coast Vassal 
	25. C25 - Cedars Vassal 
	26. C26 - Cedars Vassal
	27. C27 - Noble Charioteers 
	28. C28 - Trade with the Mural-Painters 
	29. C29 - Trade with the Storm-Followers 
	30. C30 - Trade with the Four Sisters 
	31. C31 - Trade with the River-Crossers 
	32. C32 - Trade with the Lord of Bulls 
	33. C33 - Trade with the Deep Desert 
	34. C34 - Trade with the Lapis-Miners 
	35. C35 - Trade with the Barrow-Builders 
	36. C36 - Trade with the Orange-Planters 
	37. C37 - EMPTY
	38. C38 - EMPTY 
	39. C39 - Wheel-Turner Diplomats 
	40. C40 - Royal Flagship 
	41. C41 - Naval Patrol
	42. C42 - Sun King's Decree 
	43. C43 - EMPTY 
	44. C44 - Sun King's Heralds 
	45. C45 - Zealous Administration 
3. Objective Cards 
	1. O1 - Ritualized Taxation 
	2. O2 - Peasant Unrest 
	3. O3 - Uncertain Succession 
	4. O4 - Civil War 
	5. O5 - At Sun's Edge 
	6. O6 - Moon God's Blessings 
	7. O7 - Debt Jubilee 
	8. O8 - Raise Moon Temple 
	9. O9 - Moon Temple 
	10. O10 - Plague 
	11. O11 - Raid Beyond the Cataracts 
	12. O12 - Raid the Sable Coast Princes
	13. O13 - Raid the Cedar Kings 
	14. O14 - War Beyond the Cataracts 
	15. O15 - War with the Sable Coast 
	16. O16 - War with the Cedar King 
	17. O17 - Dynasty Triumphant 
	18. O18 - Conduct Census 
	19. O19 - Raise Stele 
	20. O20 - Royal Stele 
	21. O21 - Raise Grand Monument 
	22. O22 - Grand Monument 
	23. O23 - Peasant Uprising 
	24. O26 - Envoy from the Mural-Painters 
	25. O27 - Envoy from the Storm-Followers 
	26. O28 - Envoy from the Four Sisters 
	27. O29 - Envoy from the River-Crossers 
	28. O30 - Envoy from the Lord of Bulls 
	29. O31 - Envoy from the Deep Desert 
	30. O35 - Consolidation 
	31. O36 - Border Raid 
	32. O37 - Enemy Invades!
	33. O38 - Capital besieged! 
	34. O39 - Whispers of Treason 
	35. O40 - Seditious Conspiracy 
	36. O41 - Palace Coup 
	37. O42 - Crop Failure 
	38. O43 - Famine 
	39. O44 - Desolation 
	40. O45 - Diplomatic Incident 
	41. O46 - Foreign Claimant 
	42. O47 - Vassalization 
	43. O48 - Thunderheads 
	44. O49 - Chain Lightning
	45. O50 - Distant Thunder 
	46. O51 - Plague Ships 
	47. O52 - Waylaid Shipping 
	48. O53 - Bride and Prejudice 
	49. O54 - Distant Thunder
	50. O55 - Build Eternal Pyre 
	51. O56 - Fuel Eternal Pyre 
	52. O57 - Eternal Pyre
	53. O58 - War with the Storm-Followers 
	54. O59 - War with the Mural-Painters 
	55. O60 - War with the Four-Sisters 
	56. O61 - Oil Lamp Workshop 
	57. O62 - Bronze Foundry 
