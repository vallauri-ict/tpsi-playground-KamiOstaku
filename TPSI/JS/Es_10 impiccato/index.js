"use strict";

const nomi =
        [
			"Italia", "Lavagna", "Pizza", "Lasagne", "Spiedino", "Ananas", "Gnocchi", "Gorgonzola", "Broccoli", "Mango", "Biscotti", 
			"Giornale", "Carabina", "Affettati", "Lungimirante", "Affaticato", "Effervescente", "Ambulante", "Ambulanza", "Ostetricia"
		];
const MAX_TENTATIVI=5;



const secretWord = nomi[random(0,nomi.length-1)].toUpperCase();
const secretWordDisplay = document.getElementById("txtParola");
const image = document.getElementsByTagName("img")[0];
const button = document.getElementsByTagName("button")[0];

let displayWord = "";
let triesCont = 1;

for(let i = 0; i < secretWord.length; i++)
{
	displayWord += "*";
}

secretWordDisplay.value = displayWord;

let guessedLetter = document.getElementById("txtLettera");

function converti()
{
	guessedLetter.value = guessedLetter.value.toUpperCase();
}

function elabora()
{
	if(secretWord.includes(guessedLetter.value))
	{
		for(let i = 0; i < secretWord.length; i++)
		{
			if(secretWord[i] == guessedLetter.value)
			{
				displayWord = replaceAt(displayWord,i,guessedLetter.value);
			}
		}
		secretWordDisplay.value = displayWord;
	}
	else
	{
		image.src = "img/Fig"+triesCont+".png";
		triesCont++;
	}

	if(triesCont > MAX_TENTATIVI)
	{
		alert("Hai perso");
		button.disabled = true;
		return;
	}
	else if(displayWord == secretWord)
	{
		alert("Hai vinto");
		button.disabled = true;
		return;
	}
}

function replaceAt(s,index,character)
{
	return s.substring(0, index) + character + s.substring(index + 1);
}

function random(a, b){
	return Math.floor((b-a)*Math.random()) + a;
}