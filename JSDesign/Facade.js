//facade ： 为一组复杂的子系统接口提供一个更高级的统一接口，
//通过这一接口使得子系统接口的访问更加容易
function addEvent(dom,type,fn)
{
	if(dom.addEventListener)
	{
		dom.addEventListener(type,fn,false);
	}else if(dom.attachEvent){
		dom.attachEvent('on' + type,fn);
	}else{
		dom['on' + type] = fn;
	}
}

var container = document.getElementById('container');
addEvent(container,'click',function(){
	console.log('bind one');
})
addEvent(body,'click',function(){
	console.log('body two');
})
