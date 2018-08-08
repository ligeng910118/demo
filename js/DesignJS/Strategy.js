var PriceStrategy = function()
{
	var stragtegy = {
		return30 : function(price)
		{
			return price + parseInt(price / 100) * 30;
		},
		return50 :  function(price)
		{
			return price + parseInt(price / 100) * 50;
		},
		percent90 : function(price)
		{
			return price * 100 * 90 / 10000;
		},
		percent80 :  function(price)
		{
			return price * 100 * 80 / 10000;
		},
		percent70 : function(price)
		{
			return price * 100 * 80 / 10000;
		}
	}

	return function(algorithm,price){
		return stragtegy[algorithm] && stragtegy[algorithm](price);
	}
}();

var price = PriceStrategy('return50',400);
console.log(price);