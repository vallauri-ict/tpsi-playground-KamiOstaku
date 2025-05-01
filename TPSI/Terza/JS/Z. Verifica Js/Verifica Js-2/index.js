"use strict";

const _lstVoci = document.getElementById("lstVoci");
const _txtNum = document.getElementsByClassName("txtNum");
const _txtStr = document.getElementsByClassName("txtStr");
const _chk = document.querySelectorAll("#chkRis input[type=checkbox]");
const _btnControlla = document.getElementById("btnControlla");

let valoriAscii = [];

init();

function init() 
{
    _lstVoci.selectedIndex = -1;
    valoriAscii = [];
    for (let i = 0; i < _txtNum.length; i++) 
    {
        _txtNum[i].value = "";
        _txtStr[i].value = "";
        _txtStr[i].disabled = true;
        _chk[i].checked = false;
    }
    _btnControlla.disabled = true;
}

function genera() 
{
    let range = _lstVoci.value.split("-");
    let min = parseInt(range[0]);
    let max = parseInt(range[1]);
    valoriAscii = [];

    while (valoriAscii.length < 6) 
    {
        let numero = generaNumero(min, max);
        if (!valoriAscii.includes(numero)) 
        {
            valoriAscii = valoriAscii.concat(numero);
        }
    }

    for (let i = 0; i < _txtNum.length; i++) 
    {
        _txtNum[i].value = valoriAscii[i];
        _txtStr[i].value = "";
        _txtStr[i].disabled = false;
        _chk[i].checked = false;
    }

    _btnControlla.disabled = true;
}

function abilita() {
    let tuttiCompilati = true;
    for (let campo of _txtStr) 
    {
        if (campo.value.length !== 1)
        {
            tuttiCompilati = false;
            break;
        }
    }
    _btnControlla.disabled = !tuttiCompilati;
}

function controlla() {
    let corretti = 0;

    for (let i = 0; i < valoriAscii.length; i++) 
    {
        let insertedChar = _txtStr[i].value;
        let correctedChar = String.fromCharCode(valoriAscii[i]);

        if (insertedChar === correctedChar) 
        {
            _txtStr[i].disabled = true;
            _chk[i].checked = true;
            corretti++;
        }
        else
        {
            _chk[i].checked = false;
        }
    }

    if (corretti === 6) 
    {
        alert("Complimenti! Tutte le risposte sono corrette.");
    } 
    else 
    {
        alert("Alcune risposte sono errate. Riprova.");
    }
}

function generaNumero(min, max) 
{
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

