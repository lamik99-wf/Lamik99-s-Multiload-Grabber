<?php
	$input = $_GET["a"];
	//echo ($input[1]);
	$soubor = FOpen("count.txt","r");
	$pocet = FRead($soubor,FileSize("count.txt"));
	$pocet += count($input);
	FClose($soubor);
	$soubor = FOpen("count.txt","w");
	FWrite($soubor, $pocet);
	FClose($soubor);	//just statistics, not important
	for ($j = 2; $j < 10; ++$j) // yet, max was 8
	{
		if ($j == 8) continue; //who knows what this server is... perharps one of the cancelled ones
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
