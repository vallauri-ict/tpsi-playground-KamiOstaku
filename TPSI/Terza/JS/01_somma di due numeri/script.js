"use strict"
let _divRis = document.getElementById("divRis");
let _txtN1 = document.getElementById("txtN1");
let _txtN2 = document.getElementById("txtN2");
let _txtRis = document.getElementById("txtRis");

function somma()
{
    if(_txtN1.value == "" && _txtN2.value == "")
    {
        alert("Inserisci i numeri per fare la somma");
    }
    
    let somma = parseInt(_txtN1.value) + parseInt(_txtN2.value)
    //console.log(somma);
    _divRis.innerText = somma;
    _txtRis.value = somma;
    alert(somma);
}

function abbattiLettere(event)
{
    let char = event.key;
    //if((char <= '0' || char >= '9') && char != "Backspace" &&  char != "Tab")
    if(!((char >= '0' && char <= '9') || char == "Backspace" || char == "Tab"))
        event.preventDefault();
}