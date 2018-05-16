<?php
$a = ["one","two","three"];
$b = ["1","2","3"];
$temp = $a;
$b = $a;
$a = $temp;
dump($a);
dump($b);
?>