var adapterObj = function(obj)
{
	var _adapter = {
		name : "hehua",
		title : "design",
		age : 23, 
	};
	return Object.assign(_adapter,obj);
}

var obj = {
	name:'ppd',
	size:100,
};

var mergeObj = adapterObj(obj);
console.log(mergeObj);