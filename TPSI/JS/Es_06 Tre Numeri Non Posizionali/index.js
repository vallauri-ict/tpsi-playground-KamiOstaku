"use strict"

const DIM = 3;
const userInput = document.getElementsByName("txtN");
const checks = document.getElementsByName("chkN");
const submitButton = document.getElementById("btnInvia");

let nSegreti = [];

init();

function init()
{
    submitButton.disabled = false;
    let n;
    for(let i = 0;i< DIM;i++)
    {
        n = 0;

        do
        {
            n = random(0,10);
        }while(nSegreti.includes(n));

        nSegreti.push(n);
    }
    console.log(nSegreti);
}

function random(min,max)
{
    return Math.floor((max-min)*Math.random())+min;
}

function controlla()
{
    for(let i = 0; i < DIM;i++)
    {
        if(userInput[i].value == "")
        {
            alert("I Text box non devono essere vuoti");
            return;
        }
        else
        {
            for(let j = i+1;j<DIM;j++)
            {
                if(userInput[i].value == userInput[j].value)
                {
                    alert("I numeri inseriti non devono presentare ripetizioni");
                    return;
                }
            }
        }
    }

    for(let i = 0; i < DIM; i++)
    {
        checks[i].checked = false;
    }

    let outCheck = 0;
    for(let i = 0; i < DIM; i++)
    {
        let inputValue = parseInt(userInput[i].value);
        if(nSegreti.includes(inputValue))
        {
            checks[outCheck].checked = true;
            outCheck++;
        }
    }
    if(outCheck == 3)
    {
        alert("Congratulazioni hai vinto il gioco!");
        submitButton.disabled = true;
    }
    
}

function AbbattiLettere(event)
{
    let char = event.key;

    if((char < '0' || char > '9') && char != 'Backspace')
    {
        event.preventDefault();
    }
}