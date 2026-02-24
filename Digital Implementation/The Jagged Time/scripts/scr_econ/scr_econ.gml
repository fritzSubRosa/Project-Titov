function can_afford(_player, _card)
{
	var _current = _player.resources.current;
	var _cost = _card.cost;
	
	//Check fixed costs
	
	for (var i =0; i < RESOURCE.COUNT; i++)
	{
		if (_current[i] < _cost.fixed[i])
			{
				return false;
			}
	}
	
	//Check 'any' costs
	var _total_remaining = 0;
	
	for (var i=0; i < RESOURCE.COUNT; i++) 
	{
		_total_remaining += (_current[i] - _cost.fixed[i]);
	}
	
	if (_total_remaining < _cost.any) 
	{
		return false;
	}
	
	return true;
	
}
function compose_allocation()
	{
	
	}

function validate_allocation(_player, _card, _allocation) 
	{
		var _current = _player.resources.current;
		var _required_total = 0;
		var _allocation_total = 0;
		
// Sum up _required and _allocation	

		for (i=0; i < array_length(_allocation); i++)
		{
			_allocation_total += _allocation[i]
			_required_total += (_card.cost.fixed[i])
		}
		_required_total += _card.cost.any;
		
//Check that you're paying enough and also that you have enough to pay

		for(i = 0; i < RESOURCE.COUNT; i++) 
			{
				if (_allocation[i] > _current[i])
					{
						return false;	
					}
				if (_allocation[i] < _card.cost.fixed[i])
					{
						return false
					}
			}
		if (_allocation_total != _required_total) 
			{
				return false
			}
		return true;
	}

function apply_cost()
	{
		
	}