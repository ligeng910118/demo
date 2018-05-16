var sxCalc=(function(){
      var obj={
           solar : ["甲","乙","丙","丁","午","己","庚","辛","壬","癸"],
           moon : ["子","丑","寅","卯","辰","巳","午","未","申","酉","戌","亥"],
           animal : ["鼠","牛","虎","兔","龙","蛇","马","羊","猴","鸡","狗","猪"],
           calcYourShengXiao:function(year){
              var sr = (year-1924)%10;
              var mr = (year-1924)%12;
              console.log("你是"+this.solar[ sr>=0 ? sr:10+sr ]+this.moon[ mr>=0 ? mr:12+mr]+"出生 属"+this.animal[ mr>=0 ? mr:12+mr]);
           }
      };
      return {
          get:function(){
              return obj;
          }
     }
})()
