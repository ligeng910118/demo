var Car = fucntion()
{

};

Car.prototype = {
	getPrice : function()
	{
		return new Error('abstract getPrice Error');
	},
	getSpeed : function()
	{
		return new Error('abstract getSpeed Error');
	}
}

var VehicleFactory = function(subType,superType)
{
	if(typeof VehicleFactory[subType] === 'function')
	{
		function F() {};
		F.prototype = new VehicleFactory[superType]();
		subType.constructor = subType;
		subType.prototype = new F();
	}else{
		throw new Error('no build abstract class');
	}
}

VehicleFactory.Car = function()
{
	this.type = 'car';
};
VehicleFactory.Car.prototype = {
	getPrice : function()
	{
		return new Error('car getPrice Error');
	},
	getSpeed : function()
	{
		return new Error('car getSpeed Error');
	}
};

var BMW = function(price,speed)
{
	this.price = price;
	this.speed = speed;
}

VehicleFactory(BMW,'Car');
BMW.prototype,getPrice = function()
{
	return this.price;
}
BMW.prototype.getSpeed = function()
{
	return this.speed;
}