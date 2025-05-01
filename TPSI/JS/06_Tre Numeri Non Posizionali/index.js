"use strict";
const DIM = 3;
let nSegreti = []; 
const _txtsN = document.getElementsByName("txtN"); 
const _chksN = document.getElementsByName("chkN"); 
const _btn = document.getElementById("btnInvia");
init();

function init()
{
    for(let i = 0; i < DIM; i++)
    {
        let n = 0;
        do
        {   
            n = generaNumero(1,10);
        }while(nSegreti.includes(n));
        nSegreti.push(n);
    }
    console.log(nSegreti);
}

function controlla()
{
    //Controllo che i chk non siano vuoti
    for(let i = 0; i < DIM; i++)
    {
        if(_txtsN[i].value == "")
        {
            alert("I textbox non possono essere vuoti! Inserisci i numeri");
            return;
        }
    }
    //Controllo che i numeri inseriti non siano uguali
    for(let i = 0; i < DIM - 1 ;i++)
    {
        for(let j = i + 1 ; j< DIM; j++)
        {
            if(_txtsN[i].value == _txtsN[j].value)
            {
                alert("I numeri devono essere diversi!");
                return;
            }
        }
    }
    verificaNumeri();
}

function verificaNumeri()
{
    let cont = 0;
    for(let i = 0; i < DIM; i++)
    {
        let value = parseInt(_txtsN[i].value);
        if(nSegreti.includes(value))
        {
            _chksN[cont].checked = true;
            cont++;
        }
        if(cont == 3)
        {
            alert("Hai indovinato!");
            _btn.disabled = true    ;

        }
    }
    
}

function abbattiLettere(event)
{
    let char = event.key;
    //if((char <= '0' || char >= '9') && char != "Backspace" &&  char != "Tab")
    if(!((char >= '0' && char <= '9') || char == "Backspace" || char == "Tab"))
        event.preventDefault();
}

function generaNumero(min,max)
{
    return Math.floor((max-min)*Math.random())+min;
}