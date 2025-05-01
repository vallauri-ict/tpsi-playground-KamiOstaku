"use strict";
let _wrapper = document.getElementById("wrapper");
let _txtLanci = _wrapper.getElementsByTagName("input") [0];
let _msgs = _wrapper.getElementsByTagName("p");

function genera()
{
    if(_txtLanci.value)
    {
        let nlanci = parseInt(_txtLanci.value);
        let vet = [];
        for(let i = 0; i < 6;i++)
        {
            vet[i] = 0;
        }
        for(let i = 0; i < nlanci; i++)
        {
            let  n = generaNumero(1,7);
            vet[n-1]++; 
        }
        for(let i = 0; i< 6;i++)
        {
            _msgs[i].innerHTML = `Il numero ${i+1} è uscito ${vet[i]} volte`;
            let r = generaNumero(0,256);
            let g = generaNumero(0,256);
            let b = generaNumero(0,256);
            _msgs[i].style.color = `rgb(${r}, ${g}, ${b})`;
        }       
        
    }
    else
    {
        alert("Inserisci un numero");
    }
}
function generaNumero(min,max)
{
    return Math.floor((max-min)*Math.random())+min;
}