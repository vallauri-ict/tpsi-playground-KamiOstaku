"use strict";
/*Quando parte il file di js la pagina è gia stata caricata 
  Quindi può eseguire l'accesso al dom. 
  In questo modo accedo una volta sola e il puntatore può 
  essere usato in tutte le procedure  */
let _txtLanci = document.getElementById("txtLanci");
let _lblCroce = document.getElementById("lblCroce");
let _lblTesta = document.getElementById("lblTesta");

function lanciaMoneta(){
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
function generaNumero(min,max){
    /*formula per generare un numero 
    casuale compreso tra min e max max escluso */
    let n = Math.floor((max-min)*Math.random()+min);
    return n;    
}
