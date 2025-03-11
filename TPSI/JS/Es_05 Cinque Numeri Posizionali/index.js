'use strict'

let vector = new Array (5);
let aux = [1,2,3,4,5];
let userActualGuess = document.getElementsByName("txtNum");
let checkBox = document.getElementsByName("chkNum");

for(let cont = 0; cont<5; cont++)
{
    let auxIndex = Math.floor((aux.length-0)*Math.random());

    vector[cont] = aux[auxIndex];
    aux.splice(auxIndex, 1);
}

function controlla(event)
{
    let tasto = event.key;

    if((tasto < "1" || tasto > "5") && tasto != "Backspace")
    {
        event.preventDefault();
    }
}

function confrontaNumeri()
{
    for(let i = 0;i<5;i++)
    {
        if(parseInt(userActualGuess[i].value) == vector[i])
        {
            checkBox[i].checked = "true";
            userActualGuess[i].style.backgroundColor = "green";
            userActualGuess[i].style.Color = "white";
        }
    }
}

console.info(vector);