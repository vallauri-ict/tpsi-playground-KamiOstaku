"use strict";

const RIGHE=6;
const COLONNE=7;

const GREY = "rgb(127, 127, 127)";
const YELLOW = "rgb(255, 255, 0)";
const RED = "rgb(255, 0, 0)";

<<<<<<< HEAD
const wrapper = document.getElementById("wrapper");
const nextPlayer = document.getElementById("nextPlayer");
nextPlayer.classList.add("pedina");
nextPlayer.style.backgroundColor = RED;
let activationIndex = 0;

for(let i = 0; i < RIGHE; i++)
{
    for(let j = 0; j < COLONNE; j++)
    {
        let div = document.createElement("div");
        this.style.backgroundColor = GREY;
        div.classList.add("pedina");
        wrapper.appendChild(div);
        div.id = `${i},${j}`;
        if(RIGHE-1 == i)
        {
            div.addEventListener("click",click);
        }       
    }
}

function click()
{
    this.style.backgroundColor = nextPlayer.style.backgroundColor;
    this.removeEventListener("click",click);
    
    let index = this.id.split(',');
    if(index[0] > 0)
    {
        document.getElementById(`${index[0]-1},${index[1]}`).addEventListener("click",click);
    }

    if(controlloVincita(index[0],index[1]))
    {
        alert(`Il colore ${nextPlayer.style.backgroundColor == YELLOW? "giallo" : "rosso"} ha vinto`);
    }
    else
    {
        nextPlayer.style.backgroundColor = nextPlayer.style.backgroundColor == YELLOW? RED : YELLOW;
    }
}

function controlloVincita(row,col)
{
    for(let j = 0; j < col-3;j++)
    {
        let current = document.getElementById(`${row},${j}`).style.backgroundColor;
        
        if(current != GREY)
        {
            let nex1 = document.getElementById(`${row},${j+1}`).style.backgroundColor;
            let nex2 = document.getElementById(`${row},${j+2}`).style.backgroundColor;
            let nex3 = document.getElementById(`${row},${j+3}`).style.backgroundColor;

            if(current == nex1 && nex1 == nex2 && nex2 == nex3)
        }
    }
=======

window.onload=function(){

 

>>>>>>> b212a1ee77f869da5c768d83eb18842139192ab7
}