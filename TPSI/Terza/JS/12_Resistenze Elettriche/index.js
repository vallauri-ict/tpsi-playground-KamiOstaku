"use strict";

const colori = ["Argento", "Oro", "Nero", "Marrone", "Rosso", "Arancio", "Giallo",
                "Verde", "Blu", "Viola", "Grigio", "Bianco" ];
				
const tolleranze=["10", "5", "", "1", "2", "", "", "0.5", "0.25", "0.1", "", ""];


let _lstCifra1 = document.getElementById("lstCifra1");
let _lstCifra2 = document.getElementById("lstCifra2");
let _lstFattore = document.getElementById("lstFattore");
let _lstTolleranza = document.getElementById("lstTolleranza");
let _txtRisultato = document.getElementById("txtRisultato");

init();

function init()
{
    //carico i primi 2 listobox relativi alle prime 2 cifre 0 e 1
    for(let i = 2; i < colori.length;i++)
    {
        _lstCifra1.innerHTML += `<option value=${i-2}> ${colori[i]} </option>`
        _lstCifra2.innerHTML += `<option value=${i-2}> ${colori[i]} </option>`
    }

    for(let i = 0; i < colori.length-2; i++)
    {
        _lstFattore.innerHTML += `<option value=${i-2}> ${colori[i]} </option>`
        if(tolleranze[i] != "")
        {
            _lstTolleranza.innerHTML += `<option value=${tolleranze[i]}> ${colori[i]} </option>`  
        }
    }
    _lstCifra1.selectedIndex = -1;
    _lstCifra2.selectedIndex = -1;
    _lstTolleranza.selectedIndex = -1;
    _lstFattore.selectedIndex = -1;
    
}

function calcola()
{
    let cifra1 = _lstCifra1.value;
    let cifra2 = _lstCifra2.value;
    let esponente = _lstFattore.value;
    let tolleranza = _lstTolleranza.value;
    console.log(cifra1, cifra2, esponente, tolleranza);
    let valore = parseInt(cifra1 + cifra2);
    valore = valore * Math.pow(10, esponente);
    console.log(valore);
    _txtRisultato.textContent = `${valore} ohm ± ${tolleranza}%`
}