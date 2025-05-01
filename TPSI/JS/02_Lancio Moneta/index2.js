"use strict"
const _txtLanci = document.getElementsByName("txtLanci");
const _lblTesta = document.getElementById("lblTesta");
const _lblCroce = document.getElementById("lblCroce");

function lanciaMoneta() 
{
    let cntTesta = 0;
    let cntCroce = 0;
    let nLanci = parseInt(_txtLanci.value);
    for(let i=0;i<nLanci;i++)
    {
        let nCas = generaNumero(0,2);
        if(nCas == 0)
            cntCroce++;
        else
            cntTesta++;
    }
    console.log(cntCroce, cntTesta);
    _lblCroce.innerHTML = "N. di volte in cui è uscito croce: <b>" +  cntCroce + "</b>";
    _lblTesta.innerHTML = "N. di volte in cui è uscito testa: <b>" +  cntTesta + "</b>";
    if(cntCroce > cntTesta)
    {
        _lblCroce.style.color = "red";
        _lblTesta.style.color = "green";
        alert("E' uscito più volte croce");
    }
    else if(cntCroce < cntTesta)
    {
        _lblCroce.style.color = "green";
        _lblTesta.style.color = "red";
        alert("E' uscito più volte testa");
    }
    else
    {
        _lblCroce.style.color = "blue";
        _lblTesta.style.color = "blue";
        alert("Il numero di volte è uguale  ");
    }
}

function generaNumero(min, max)
{
    let n = Math.floor((max - min) * Math.random() + min);
    return n;
}
