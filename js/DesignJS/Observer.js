var Observer = (function(){
	var _messages = {};
	return {
		regist : function(type,fn)
		{
			if(typeof _messages[type] === 'undefined')
			{
				_messages[type] = fn;
			}else{
				_messages[type].push(fn);
			}
		},
		fire : function(type,args)
		{
			if(!_messages[type])
				return;
			var events = {
				type : type,
				args : args || {}
			},
			length = _messages[type].length;
			for(var i = 0;i <length ; i++)
			{
				_messages[type].call(this,events);
			}
		},
		remove : function(type,fn)
		{
			if(_messages[type] instanceof Array)
			{
				length = _messages[type].length;
				for(var i = length - 1;i >= 0; i--)
				{
					_messages[type] === fn && _messages[type].splice(i,1);
				}
			}
		},
		check : function()
		{
			console.log(_messages);
		}
	}
})();
Observer.regist('test',function(e){
	console.log(e.type,e.args.msg);
});
Observer.regist('test2',function(e){
	console.log(e.type,e.args.msg);
});
Observer.check();
Observer.fire('test',{msg:'param'});
Observer.fire('test2',{msg:'param2'});