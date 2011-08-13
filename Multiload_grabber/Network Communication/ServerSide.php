<?php
	$input = $_GET["a"];
	$serv = $_GET["serv"];
	$servcount = 9;
	$allenabled = "111111111"; //1 servcount times
	/*New feature : Don't grab links that we don't need. "serv" is a list of servers hash : 
	1 ... CZshare, not used
	2 ... Hellshare
	3 ... Share-Rapid
	4 ... Rapidshare
	5 ... Uloz.to
	6 ... Quickshare
	7 ... Multishare
	8 ... ??????
	9 ... FileFactory
	... still place for 20 more servers in 32bit ;)*/
	/*$soubor = FOpen("count.txt","r");
	$pocet = FRead($soubor,FileSize("count.txt"));
	$pocet += count($input);
	FClose($soubor);
	$soubor = FOpen("count.txt","w");
	FWrite($soubor, $pocet);
	FClose($soubor);	//just statistics, not important*/
	
	//decrypting the servers hash + backwards compatibility
	if ($serv==0)
		$str = $allenabled;
	else 
		$str = decbin($serv);
	$str = strrev($str);
	for ($j = 2; $j <=$servcount; ++$j)
	{
		if ($j == 8 || j >= strlen($str) || $str[$j-1]!='1') continue; //who knows what the server 8 is... perharps one of the cancelled ones
		for ($i = 0; $i < count($input); ++$i)
		{		
			$s = "http://www.multiload.cz/html/stahnout_process.php?akce=download&id={$input[$i]}&server={$j}";
			//echo($s);
			$ch = curl_init($s);
	
			curl_setopt($ch, CURLOPT_HEADER, true);
			curl_setopt($ch, CURLOPT_NOBODY, true);
			curl_setopt($ch, CURLOPT_FOLLOWLOCATION, false);
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
	
			$response = curl_exec($ch);
			curl_close($ch);
	
			$header = "Location: ";
			$pos = strpos($response, $header);
			$pos += strlen($header);
			$redirect_url = substr($response, $pos, strpos($response, "\r\n", $pos)-$pos);
			echo $redirect_url;
			echo("\n");
		}
	}
?>