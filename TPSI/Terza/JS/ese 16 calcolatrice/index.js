"use strict"

let display, result, btnEqual, btnNumber, btnOperazioni,operation,btnCanc;

window.onload = function () {

    display = document.getElementById("txtDisplay");
    btnEqual = document.getElementById("btnCalcola");
    btnNumber = document.getElementsByName("btnNum");
    btnOperazioni = document.getElementsByName("btnOperatore");
    btnCanc = document.getElementById("btnClear");

    result = 0;

    for (let i = 0; i < btnNumber.length; i++) {
        btnNumber[i].addEventListener("click", numberSelector);
    }
    for (let i = 0; i < btnOperazioni.length; i++) {
        btnOperazioni[i].addEventListener("click", selectOperation);
    }
    btnEqual.addEventListener("click",showResult); 
    btnCanc.addEventListener("click",cancel);
}

function numberSelector(event) {
    display.value += event.target.value;
}

function selectOperation(event)
{
    result = parseFloat(display.value);
    display.value = "";
    operation = event.target.value;
}

function showResult(event)
{
    switch(operation)
    {
        case '+':
            result += parseFloat(display.value);
        break;

        case '-':
            result -= parseFloat(display.value);
        break;

        case '/':
            result /= parseFloat(display.value);
        break;

        case '*':
            result *= parseFloat(display.value);
        break;
    }
    display.value = result;
}

function cancel()
{
    result = 0;
    display.value = "";
    operation = "";
}