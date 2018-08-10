var A = A || {};
A.root = document.getElementById('container');
A.strategy = {
	'listPart' : function(data)
	{
		var s = document.createElement('div'),
		ul = '',
		ldata = data.data.li,
		tpl = [
			'<h2>{#h2#}</h2>',
			'<ul>{#ul#}</ul>',
			'<p>{#p#}</p>'
		].join(''),
		liTpl = [
			'<li>',
				'<strong>{#strong#}</strong>',
				'<span>{#span#}</span>',
			'</li>'
		].join('');
		data.id && (s.id = data.id);
		for(var i = 0,len = ldata.length; i < len; i++)
		{
			if(ldata[i].em || ldata[i].span)
			{
				ul += A.formateString(liTpl,ldata[i]);
			}
		}
		data.data.ul = ul;
		s.innerHTML = A.formateString(tpl,data.data);
		A.root.appendChild(s);
	},
	'codePart' : function(){},
	'onlyTitle' : function(){},
	'guide' :  function(){}
}

A.init = function(data)
{
	this.strategy[data.type](data);
}
A.formateString = function(str,data)
{
	return str.replace(/\{#(\w+)#\}/g,function(match,key){
		return typeof data[key] === undefined ? ' ': data[key]
	});
}