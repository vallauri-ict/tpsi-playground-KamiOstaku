"use strict";

const DIM = 5;
let nSegreti = [];
let aus = [1, 2, 3, 4, 5];
let txtNums = document.getElementsByName("txtNum");
let chkNums = document.getElementsByName("chkNum");

for(let i = 0; i < DIM; i++)
{
    let pos = random(0, aus.length);

    nSegreti[i] = aus[pos];
    aus.splice(pos, 1);
}

function controlla(event)
{
    let tasto = event.key;

    // if(!(tasto >= "1" && tasto <= "5") || tasto == "Backspace")


    if((tasto < "1" || tasto > "5") && tasto != "Backspace") 
    {
        event.preventDefault();
    }
}

function confrontaNumeri()
{
    if(!numeriValidi())
    {
        alert("I numeri devono essere diversi tra loro");
        return;
    }

    let cnt = 0;

    for (let i = 0; i < DIM; i++) 
    {
        if(txtNums[i].value == nSegreti[i])
        {
            chkNums[i].checked = "true";
            txtNums[i].style.backgroundColor = "green";
            txtNums[i].style.color = "white";
            cnt++;
        }
    }

    if(cnt == 5)
    {
        let btnGioca = document.getElementById("btnInvia");
        btnGioca.disabled = "true";
    }
}

function numeriValidi()
{
    for(let i = 0; i < DIM - 1; i++)
    {
        for(let j = i + 1; j < DIM; j++)
        {
            if(txtNums[i].value === txtNums[j].value)
            {
                return false;
            }
        }
    }

    return true;
}

function random(min, max)
{
    return Math.floor((max - min) * Math.random()) + min;
}
