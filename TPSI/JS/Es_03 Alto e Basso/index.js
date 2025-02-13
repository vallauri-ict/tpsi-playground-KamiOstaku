'use strict'

let text = document.getElementById("divMessaggio").innerHTML;
let triesPrint = document.getElementById("divTentativi").innerHTML;
let secretNum = NumberGenerator(1,101);
let tries = 0;

function Gioca()
{
    let guess = parseInt(document.getElementById("txtNumero").value);

    if(guess < 1 || guess > 100)
    {
        userGuess.value = "";
        userGuess.focus();
    }
    else
    {
        tries++;
        if(guess < secretNum)
        {
            text = "The number you inserted is lower";
        }
        else if(guess > secretNum)
        {
            text = "The number you inserted is higher"; 
        }
        else
        {
            text = "You guessed the number congratulation!!";
            EndGame();
        }
        triesPrint = "Tries : " + tries;
    }
}

function EndGame()
{
    txtNumero.disable = true;
}

function NumberGenerator(a,b)
{
    return Math.floor((b-a)*Math.random()+a);
}