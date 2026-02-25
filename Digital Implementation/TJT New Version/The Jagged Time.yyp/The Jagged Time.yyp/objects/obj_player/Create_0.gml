resources = {
	current: array_create(RESOURCE.COUNT, 0),
	maximum: array_create(RESOURCE.COUNT,0)
}


//Hardcoded start test values

resources.current[RESOURCE.FOOD] = 5;
resources.current[RESOURCE.STABILITY] =1;
resources.current[RESOURCE.INFLUENCE] =0;
resources.current[RESOURCE.MIGHT] = 1;
resources.current[RESOURCE.TRADE_GOODS] = 0;

resources.maximum[RESOURCE.FOOD] = 5;
resources.maximum[RESOURCE.STABILITY] = 5;
resources.maximum[RESOURCE.INFLUENCE] = 5;
resources.maximum[RESOURCE.MIGHT] = 5;
resources.maximum[RESOURCE.TRADE_GOODS] = 5;


var _testingPub = variable_struct_get(global.card_definitions, "public_rituals");
var _testingAllocation = [1,0,0,0,0];

var _result = can_afford(self, _testingPub)
var _validationResult = validate_allocation(self, _testingPub,_testingAllocation)

show_debug_message("Can afford test card: " + string(_result));
show_debug_message("Allocation is valid: " + string(_validationResult));