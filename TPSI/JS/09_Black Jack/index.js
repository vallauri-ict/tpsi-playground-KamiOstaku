"use strict";
const _txtBanco = document.getElementById("txtBanco");
const _chkNum = document.getElementsByName("chkNum");
const _txtNum = document.getElementsByName("txtNum");
const _txtUser = document.getElementById("txtUser");
const _btnBanco = document.getElementById("btnBanco");
let nBanco = generaNumero(1,11);

_txtBanco.value = nBanco;
let somma = 0;
let sommaBanco = 0;


function visualizza(n)
{

    _chkNum[n].disabled = true;
    _txtNum[n].value = generaNumero(1,11);
    somma += parseInt(_txtNum[n].value);
    _txtUser.value = somma;
    if(_txtUser.value > 21)
    {
        alert("Hai perso");
        finePartita();
    }

}

function banco()
{
    sommaBanco = parseInt(_txtBanco.value);
    sommaBanco += generaNumero(1,11);
    _txtBanco.value = sommaBanco;
    for(let i = 0; i < _chkNum.length;i++)
    {
        _chkNum[i].disabled = true;

    }
    if(_txtBanco.value > 17)
    {
        _btnBanco.disabled = true;
    }
    else if(_txtBanco.value > 21)
    {
        _btnBanco.disabled = true;
        alert("Il giocatore ha vinto")
        finePartita();
    }
    else if(_txtBanco.value >= 17 && _txtBanco.value < 21)
    {
        if(_txtBanco.value > _txtUser.value)
            {
                alert("Ha vinto il banco!");
                finePartita();
            }
            else if(_txtBanco.value == _txtUser.value)
            {
                alert("Il Banco ha vinto!")
                finePartita();
            }
            else 
            {
                alert("Il giocatore ha vinto!")
                finePartita();
            }
        
    }
    
}

function finePartita()
{
    for(let i = 0; i < _chkNum.length;i++)
    {
        _chkNum[i].disabled = true;
        _btnBanco.disabled = true;
    }
}

function generaNumero(min,max)
{
    return Math.floor((max-min)*Math.random())+min;
}
