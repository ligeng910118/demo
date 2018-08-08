var  CanvasCommand = (function(){
	var canvas = document.getElementById('canvas');
	var ctx = canvas.getContext('2d');

	var Action = {
		fillStyle : function(c)
		{
			ctx.fillStyle = c;
		},

		fillRect : function(x,y,width,height)
		{
			ctx.fillRect(x,y,width,height);
		},
		strokeStyle : function(c)
		{
			ctx.strokeStyle = c;
		},
		strokeRect : function(x,y,width,height)
		{
			ctx.strokeRect(x,y,width,height);
		},
		fillText : function(text,x,y)
		{
			ctx.fillText(text,x,y);
		},
		beginPath : function()
		{
			ctx.beginPath();
		},
		moveTo : function(x,y)
		{
			ctx.moveTo(x,y);
		},
		lineTo : function(x,y)
		{
			ctx.lineTo(x,y);
		},
		arc : function(x,y,r,begin,end,dir)
		{
			ctx.arc(x,y,r,begin,end,dir);
		},
		fill : function()
		{
			ctx.fill();
		},
		stroke : function()
		{
			ctx.stroke();
		},
	}

	return {
		excute : function(msg)
		{
			if(!msg)
				return;
			if(msg.length){
				for(var i = 0,len = msg.length; i < len ; i++)
					arguments.callee(msg[i]);
			}else{
				msg.param = Object.prototype.toString.call(msg.param) === "[object Array]" ? msg.param :[msg.param];
				Action[msg.command].apply(Action,msg.param);
			}
		}
	}
})();

CanvasCommand.excute([
	{command:'fillStyle',param:'red'},
	{command:'fillRect',param:[0,0,100,100]},
]);