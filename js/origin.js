//object
var model = {
	_count:0,
	m1:function()
	{

	},
	m2:function()
	{

	},
};
model.m1();
model._count;

//IIFE
var model2 = (function(){
	var _count = 0;
	var m1 = function()
	{

	};
	var m2 = function()
	{

	};

	var get_count = function()
	{
		return _count;
	};

	var set_count = function(count)
	{
		_count = count;
	};
	return {
		m1 : m1,
		m2 : m2,
		get_count : get_count,
		set_count : set_count,
	};
})(); 
