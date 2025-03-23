"use strict";

const banco = document.getElementById("txtBanco");
const bancoBtn = document.getElementById("btnBanco");
const giocatore = document.getElementById("txtUser");
const checkText = document.getElementsByName("txtNum");
const check = document.getElementsByName("chkNum");

banco.value = random(2,10);
giocatore.value = 0;

function visualizza(a)
{
    check[a].disabled = true;
    checkText[a].value = random(2,10);

    giocatore.value = parseInt(checkText[a].value) + parseInt(giocatore.value);
    
    if(giocatore.value > 21)
    {
        disableCheckbox();
        bancoBtn.disabled = true;

        alert("hai perso");
    }
}

function bancoFunction()
{
    do
    {
        banco.value = random(2,10) + parseInt(banco.value)

    }while(banco.value < 17);
    
    if(banco.value-'0' > 21)
    {
        alert("hai vinto");
    }
    else
    {
         alert(banco.value-'0' >= giocatore.value-'0' ? "ha vinto il banco" : "ha vinto il giocatore");
    }
    disableCheckbox();
    bancoBtn.disabled = true;
}

function random(a, b)
{
	return Math.floor((b-a)*Math.random()) + a;
}

function disableCheckbox()
{
    for(let i = 0; i < 8; i++)
    {
        check[i].disabled = true;
    }
}