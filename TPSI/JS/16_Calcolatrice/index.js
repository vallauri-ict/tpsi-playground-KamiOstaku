"use strict"

const _btnNumeri = document.getElementsByName("btnNum");
const _btnOperatori = document.getElementsByName("btnOperatore");
const _btnCalcola = document.getElementById("btnCalcola");
const _btnClear = document.querySelector("#btnClear");
const _txtDisplay = document.querySelector("#txtDisplay");

let firstNumber = 0;
let operator;

_btnCalcola.addEventListener("click", calcola);
_btnClear.addEventListener("click", function()
{
    _txtDisplay.value = "";
    firstNumber = 0;
    operator = "";
});

//for(let i = 0; i< _btnNumeri.length; i++) 
for (let _btn of _btnNumeri)
{
    _btn.addEventListener("click", viusualizzaNumero);
}
for (let _btn of _btnOperatori)
{
    _btn.addEventListener("click", memorizzaOperatore);
}
function calcola()
{
    let ris = 0;
    let secondNumber = parseFloat(_txtDisplay.value);
    switch (operator)
    {
        case "+":
            ris = firstNumber + secondNumber;
            break;
        case "-":
            ris = firstNumber - secondNumber;
            break;
        case "*":
            ris = firstNumber * secondNumber;
            break;
        case "/":
            ris = firstNumber / secondNumber;
            break;
    }
    _txtDisplay.value = ris;
}

function memorizzaOperatore()
{
    operator = this.value;
    firstNumber = parseFloat(_txtDisplay.value);   
    _txtDisplay.value = "";

}
function viusualizzaNumero()
{
    let n = this.value;
    if(!(n == "." && _txtDisplay.value.includes(".")))
    {
        _txtDisplay.value += n;
    }
}